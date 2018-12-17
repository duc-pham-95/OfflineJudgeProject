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
    public partial class Wrong : Form
    {
        private string[] WrongAnswers;
        public Wrong(string[] WrongAnswers)
        {
            InitializeComponent();
            this.WrongAnswers = WrongAnswers;
            InitWrongInfo();
        }
        private void InitWrongInfo()
        {
            lbShowResult.Text = "Wrong Answer";
            lbShowTest.Text = WrongAnswers[2];
            rtbxInput.Text = Model.Files.GetFileContentText(WrongAnswers[3]);
            rtbxYour.Text = Model.Files.GetFileContentText(WrongAnswers[0]);
            rtbxCorrect.Text = Model.Files.GetFileContentText(WrongAnswers[1]);
            if(WrongAnswers[4] == null)
            {
                rtbxCorrect.Find(WrongAnswers[5]);
                rtbxCorrect.SelectionColor = Color.Red;
            }
            else if(WrongAnswers[5] == null)
            {
                rtbxYour.Find(WrongAnswers[4]);
                rtbxYour.SelectionColor = Color.Red;
            }
            else
            {
                rtbxYour.Find(WrongAnswers[4]);
                rtbxYour.SelectionColor = Color.Red;
                rtbxCorrect.Find(WrongAnswers[5]);
                rtbxCorrect.SelectionColor = Color.Red;
            }
        }

        private void btnOpenYour_Click(object sender, EventArgs e)
        {
            Model.Commands.OpenFile(WrongAnswers[0]);
        }

        private void btnOpenCorrect_Click(object sender, EventArgs e)
        {
            Model.Commands.OpenFile(WrongAnswers[1]);
        }

        private void btnAllOut_Click(object sender, EventArgs e)
        {
            Model.Commands.OpenFolder(Model.Directories.GetOutDir());
        }

        private void btnOpenInput_Click(object sender, EventArgs e)
        {
            Model.Commands.OpenFile(WrongAnswers[3]);
        }
    }
}
