using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfflineJudgeApp
{
    public partial class Main : Form
    {
        private string Error;
        private Boolean java = false;
        private Boolean csharp = false;
        private int test = 0;

        public object Sleep { get; private set; }

        public Main()
        {
            InitializeComponent();
            Model.Directories.CreateAll();//tao tat ca folder can thiet
            cbxLanguage.SelectedIndex = 0;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            ResetInfomation();
            Model.Directories.ClearAll(); //clear all files in Base folders
            if(isDataTestPathExisted() && isSourceCodeExisted() && isLanguageSelected())
            {
                DisableBtn();
                if (cbxLanguage.SelectedIndex == 0)
                {
                    java = true;
                    csharp = false;
                }
                else
                {
                    csharp = true;
                    java = false;
                }
                TransformToFileCode(GetRawSourceCode());//convert text to java file              
                backgroundWorker.RunWorkerAsync();// run
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
           if(java)
                excuteJava();
           else
                excuteCSharp();
        }
        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(Error.Equals("") || Error.Equals("Time Limit Exceeded") && test > 1)
            {
                if (Error.Equals(""))
                {
                    lbMessage.Text = "Successful";
                }
                string[] wrongAnswers = Model.Compare.Diff(Model.Directories.GetOutDir(), Model.Directories.GetTestOutputDir());   
                if(wrongAnswers != null)
                {
                    Wrong wrong = new Wrong(wrongAnswers);
                    wrong.ShowDialog();
                }
                else
                {
                    Passed pass = new Passed();
                    pass.ShowDialog();
                }
            }
            EnableBtn();
            lbState.Text = "Completed";
        }   

        private void TransformToFileCode(string[] text)
        {
            if (java)
                Model.Files.WriteTextToFile(Model.Files.GetJavaFilePath(), text);
            else
                Model.Files.WriteTextToFile(Model.Files.GetCSharpFilePath(), text);
        }
        private string[] GetRawSourceCode()
        {
            int n = txtRawSourceCode.Lines.Length;
            string[] text = new string[n];
            for (int i = 0; i < n; i++)
            {
                text[i] = txtRawSourceCode.Lines[i];
            }
            return text;
        }
        
        private void InitButtonSeeDetailError()
        {
            Button btnSeeDetail = new Button();
            btnSeeDetail.Click += SeeDetailError;
            btnSeeDetail.Location = new Point(17, 80);
            btnSeeDetail.Size = new System.Drawing.Size(130, 25);
            btnSeeDetail.TabIndex = 13;
            btnSeeDetail.Text = "See detail error >>";
            btnSeeDetail.UseVisualStyleBackColor = true;
            grbxRunningInfo.Controls.Add(btnSeeDetail);  
        }

        private void SeeDetailError(object sender, EventArgs e)
        {
            ErrorForm er = new ErrorForm(Error);
            er.ShowDialog(); 
        }
        private void ResetInfomation()
        {
            Error = "";
            lbMessage.Text = "";
            lbState.Text = "";
        }
        private Boolean isSourceCodeExisted()
        {
            if (txtRawSourceCode.Lines.Length == 0)
            {
                MessageBox.Show("Source code is empty, please insert !", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private Boolean isDataTestPathExisted()
        {
            if (Model.Directories.DataTest == null && Model.Directories.InputDir == null && Model.Directories.TestOutputDir == null)
            {
                MessageBox.Show("Test Data folders must be given before running code !", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
       
        private void isNetFrameWorkExitsted()
        {
            string path = Model.Directories.GetPathNetFramework();
            if(path == "None")
            {
                MessageBox.Show(".Net FrameWork not found ! please make sure you've already installed it", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxLanguage.SelectedIndex = 0;
            }
            else
            {
               
                Model.Commands.NetFrameWorkPath = path;
            }
        }
        private Boolean isLanguageSelected()
        {
            if(cbxLanguage.SelectedItem == null)
            {
                MessageBox.Show("No language found ! please select a language", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.ShowDialog();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            TestData test = new TestData();
            test.ShowDialog();
        }

        private void btnInstruction_Click(object sender, EventArgs e)
        {
            Instruction instruction = new Instruction();
            instruction.ShowDialog();
        }
        public void DisableBtn()
        {
            btnSetting.Enabled = false;
            btnStart.Enabled = false;
            btnTest.Enabled = false;
        }
        public void EnableBtn()
        {
            btnSetting.Enabled = true;
            btnStart.Enabled = true;
            btnTest.Enabled = true;
        }
        private void excuteJava()
        {
            Invoke((MethodInvoker)delegate
            {
                lbState.Text = "Compiling...";
            });
            Error = Model.Commands.ProcessCompileJava(); //compile
            if (Error.Length > 0)//neu loi trong qua trinh compile
            {
                Invoke((MethodInvoker)delegate
                {
                    lbMessage.Text = Model.Messages.GetErrorType(Error);//xac dinh loi gi
                    InitButtonSeeDetailError(); //the hien loi chi tiet
                });
            }
            else
            {
                //string[] InputFilePaths = Model.Files.GetInputFilePaths(Model.Directories.InputDir);// tap hop paths cua tung file input dau vao
                //string[] OutputFilePaths = Model.Files.GetOutputFilePaths(Model.Directories.InputDir);//tap hop paths cua tung file output dau ra    
                string[] Commands = Model.Files.GetRunJavaCommands(Model.Directories.GetTestInputDir());
                int i = 1;
                test = 0;
                foreach (string command in Commands)
                {
                    //string FileInputContent = Model.Files.GetFileContentText(InputFilePath);// lay noi dung cua 1 file input
                    Invoke((MethodInvoker)delegate
                    {
                        lbState.Text = "Running Test " + i + "...";
                    });
                    //Model.Result result = Model.Commands.ProcessRunJava(FileInputContent);//run 
                    Model.Result result = Model.Commands.ProcessRunJava(command);
                    if (result.Error != "")
                    {
                        test = i;
                        Error = result.Error;
                        Invoke((MethodInvoker)delegate
                        {
                            lbMessage.Text = Model.Messages.GetErrorType(result.Error);
                            InitButtonSeeDetailError();
                        });
                        for (int t = 10; t >= 0; t--)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                lbState.Text = "Before complete " + "(" + t + ")";
                            });
                            Thread.Sleep(1000);
                        }
                        break;
                    }
                    //File.WriteAllText(OutputFilePaths[i - 1], result.Output); //ghi ket qua xuong tung file output
                    i++;
                }

            }
        }
        private void excuteCSharp()
        {
            Invoke((MethodInvoker)delegate
            {
                lbState.Text = "Compiling...";
            });
            Error = Model.Commands.ProcessCompileCSharp(); //compile
            if (Error.Length > 0)//neu loi trong qua trinh compile
            {
                Invoke((MethodInvoker)delegate
                {
                    lbMessage.Text = Model.Messages.GetErrorCSharpType(Error);//xac dinh loi gi
                    InitButtonSeeDetailError(); //the hien loi chi tiet
                });
            }
            else
            {
                //string[] InputFilePaths = Model.Files.GetInputFilePaths(Model.Directories.InputDir);// tap hop paths cua tung file input dau vao
                //string[] OutputFilePaths = Model.Files.GetOutputFilePaths(Model.Directories.InputDir);//tap hop paths cua tung file output dau ra    
                string[] Commands = Model.Files.GetRunCSharpCommands(Model.Directories.GetTestInputDir());
                int i = 1;
                foreach (string command in Commands)
                {
                    //string FileInputContent = Model.Files.GetFileContentText(InputFilePath);// lay noi dung cua 1 file input
                    Invoke((MethodInvoker)delegate
                    {
                        lbState.Text = "Running Test " + i + "...";
                    });
                    //Model.Result result = Model.Commands.ProcessRunJava(FileInputContent);//run 
                    Model.Result result = Model.Commands.ProcessRunCSharp(command);
                    if (result.Error != "")
                    {
                        Error = result.Error;
                        Invoke((MethodInvoker)delegate
                        {
                            lbMessage.Text = Model.Messages.GetErrorCSharpType(result.Error);
                            InitButtonSeeDetailError();
                        });
                        for (int t = 15; t >= 0; t--)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                lbState.Text = "Before complete " + "(" + t + ")";
                            });
                            Thread.Sleep(1000);
                        }
                        break;
                    }
                    //File.WriteAllText(OutputFilePaths[i - 1], result.Output); //ghi ket qua xuong tung file output
                    i++;
                }

            }
        }

        private void cbxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxLanguage.SelectedIndex == 1)
            {
                String path = Application.StartupPath + @"\Microsoft.Net.Compilers.2.8.2\tools\";
                if(Directory.Exists(path)){
                    Model.Commands.StartupPath = path+"csc.exe";
                }
                else
                {
                    cbxLanguage.SelectedIndex = 0;
                    MessageBox.Show("\\Microsoft.Net.Compilers.2.8.2\\tools\\csc.exe not found !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
