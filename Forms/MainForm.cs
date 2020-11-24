using Lets__study_.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lets__study_.Forms
{
    public partial class MainForm : Form
    {
        private QuestionFrm Child { get; set; }
        public MainForm(QuestionFrm child)
        {
            InitializeComponent();
            Child = child;
        }

        private void HelpManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"Resources/Help.chm");
        }
    }
}
