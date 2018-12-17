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
    public partial class Passed : Form
    {
        public Passed()
        {
            InitializeComponent();
        }
        private void btnAllOut_Click(object sender, EventArgs e)
        {
            Model.Commands.OpenFolder(Model.Directories.GetOutDir());
        }
    }
}
