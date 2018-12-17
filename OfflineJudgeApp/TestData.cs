using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfflineJudgeApp
{
    public partial class TestData : Form
    {
        public TestData()
        {
            InitializeComponent();
            rbtnSp.Enabled = false;
            init();
           
        }
        private void init()
        {
            txtOutput.Enabled = false;
            txtInput.Enabled = false;
            txbTestCase.Enabled = false;
            btnOutput.Enabled = false;
            btnInput.Enabled = false;
            btnTestCase.Enabled = true;
            rbtnSp.Checked = false;
            rbtnNotSp.Checked = true;
            if(Model.Directories.InputDir != null && Model.Directories.TestOutputDir != null)
            {
                rbtnNotSp.Checked = false;
                rbtnSp.Checked = true;
                btnOutput.Enabled = true;
                btnInput.Enabled = true;
                btnTestCase.Enabled = false;
                txtInput.Text = Model.Directories.InputDir;
                txtOutput.Text = Model.Directories.TestOutputDir;
            }
            else if(Model.Directories.DataTest != null)
            {
                txbTestCase.Text = Model.Directories.DataTest;
            }

        }
        private void btnTestCase_Click(object sender, EventArgs e)
        {
            GetIOExample(1);
        }
        private void btnInput_Click(object sender, EventArgs e)
        {
            GetIOExample(2);
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            GetIOExample(3);
        }
        public void GetIOExample(int I)
        {
            FolderBrowserDialog FolderChooser = new FolderBrowserDialog();
            if (FolderChooser.ShowDialog() == DialogResult.OK)
            {
                string path = FolderChooser.SelectedPath;
                if (path.Length > 0)
                {

                    if (Model.Directories.isDirEmpty(path) == false)
                    {
                        if (I == 2)
                        {
                            txtInput.Text = path;
                        }
                        else if(I == 3)
                        {
                            txtOutput.Text = path;
                        }
                        else
                        {
                            txbTestCase.Text = path;
                        }
                        FolderChooser.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("the folder is empty ! no data found !");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtnNotSp.Checked)
            {
                if (txbTestCase.Text == "")
                {
                    MessageBox.Show("Test Data folder not found !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Model.Directories.DataTest = txbTestCase.Text;
                    Model.Directories.ClearSysTestInDir();
                    Model.Directories.ClearSysTestOutDir();
                    Model.Files.CopyTestFilesToSysFolder(Model.Directories.DataTest);
                    Dispose();
                }
            }
            else
            {
                if (txtInput.Text == "")
                {
                    MessageBox.Show("Test Input folder not found !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtOutput.Text == "")
                {
                    MessageBox.Show("Test Output folder not found !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Model.Directories.TestOutputDir = txtOutput.Text;
                    Model.Directories.InputDir = txtInput.Text;
                    Dispose();
                }
            }
        }
        private void rbtnNotSp_Click(object sender, EventArgs e)
        {
            Model.Directories.TestOutputDir = null;
            Model.Directories.InputDir = null;
            txtInput.Text = "";
            txtOutput.Text = "";
            btnInput.Enabled = false;
            btnOutput.Enabled = false;
            btnTestCase.Enabled = true;
        }

        private void rbtnSp_Click(object sender, EventArgs e)
        {
            Model.Directories.DataTest = null;
            txbTestCase.Text = "";
            btnInput.Enabled = true;
            btnOutput.Enabled = true;
            btnTestCase.Enabled = false;
        }
    }
}
