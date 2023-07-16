using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace Sobreclick
{
    public partial class excpt : Form
    {
        public static string errorDesc;
        public excpt(string err)
        {
            errorDesc = err;
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(strings.scRepositorio);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            infoBtn.Visible = false;
            lblExcpt.Text = errorDesc;
            lblExcpt.Visible = true;
        }
    }
}
