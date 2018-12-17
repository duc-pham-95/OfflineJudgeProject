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
    public partial class Setting : Form
    {
        string path;
        public Setting()
        {
            InitializeComponent();
            initMore();
        }

        private void initMore()
        {
            numericUpDownTimeLimit.Value = Model.Commands.Time;
            txtOutput.Text = Model.Directories.GetOutDir();
            cmboxOutputType.Items.Add(Model.Files.TextFileType);
            cmboxOutputType.Items.Add(Model.Files.OutputFileType);
            cmboxOutputType.Items.Add(Model.Files.AnswerFileType);
            if(Model.Files.customFileType.Equals(Model.Files.TextFileType))
                cmboxOutputType.SelectedIndex = 0;
            else if(Model.Files.customFileType.Equals(Model.Files.OutputFileType))
                cmboxOutputType.SelectedIndex = 1;
            else if(Model.Files.customFileType.Equals(Model.Files.AnswerFileType))
                cmboxOutputType.SelectedIndex = 2;
            cmboxOutputType.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void btnOutputDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderChooser = new FolderBrowserDialog();
            if (FolderChooser.ShowDialog() == DialogResult.OK)
            {
                path = FolderChooser.SelectedPath;
                if (path.Length > 0)
                {
                    txtOutput.Text = path;
                    FolderChooser.Dispose();
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(path != null)
            {
                Model.Directories.CustomOutputDir = path;
            }
            if(numericUpDownTimeLimit.Value != 2000 && numericUpDownTimeLimit.Value != 0)
            {
                Model.Commands.Time =  Convert.ToInt32(numericUpDownTimeLimit.Value);
            }
            Model.Files.customFileType = cmboxOutputType.SelectedItem.ToString();
            Dispose();
        }
    }
}
