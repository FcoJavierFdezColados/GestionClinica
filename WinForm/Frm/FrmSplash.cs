﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm.Frm
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void timerFrmSplash_Tick(object sender, EventArgs e)
        {
            if (pbFrmSplash.Value < pbFrmSplash.Maximum)
            {
                pbFrmSplash.Value += pbFrmSplash.Step;
            }
            else
            {
                Close();
            }
        }
    }
}
