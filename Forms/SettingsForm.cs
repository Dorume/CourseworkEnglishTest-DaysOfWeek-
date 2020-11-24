﻿using System;
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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void CountOfQuestions_Scroll(object sender, EventArgs e)
        {
            Properties.Settings.Default.CountOfQuestions = CountOfQuestions.Value;
            Properties.Settings.Default.Save();
        }
    }
}
