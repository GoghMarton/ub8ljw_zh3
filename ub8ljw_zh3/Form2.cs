﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ub8ljw_zh3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            Regex reg = new Regex("^[A-Z{1}][a-zA-Z]");

            if (!reg.IsMatch(textBoxName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxName, "A névnek nagybetűvel kezdődnie és nem lehet üresen hagyni!");

            }
        }

        private void textBoxName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxName, "");
        }

        private void textBoxSalutation_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSalutation.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxSalutation, "Nem lehet üresen hagyni ezt mezőt!");
            }
        }

        private void textBoxSalutation_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxSalutation, "");
        }
    }
}
