using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Resources;
using System.IO;

namespace Sobreclick
{
    public partial class sc_exe : Form
    {
        // Variables
        string dir_exe;
        string args_exe;
        strings SC = new strings();
        public static ResourceManager rm = new ResourceManager(typeof(sc_exe));
        public bool activado = false;
        public string args = "";

        public sc_exe()
        {
            InitializeComponent();
        }

        private void btnAcpt_Click(object sender, EventArgs e)
        {
            switch (aceptarEjecutable())
            {
                case true:
                    this.Close();
                    break;
            }
        }

        public void cancelarEjecutable()
        {
            activado = false;
        }

        public bool aceptarEjecutable()
        {
            dir_exe = tbDirExe.Text;
            if (tbArgsExe.Enabled)
            {
                args_exe = tbArgsExe.Text;
            }
            if (dir_exe == "")
            {
                MessageBox.Show(rm.GetString("msgErrorBlank"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                sobreclick.dirProgramaScript = dir_exe;
                sobreclick.argsProgramaScript = args_exe;
                activado = true;
                return true;
            }
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
                if (tbArgsExe.Enabled)
                {
                    args = tbArgsExe.Text;
                }
                else
                {
                    args = "";
                }

                if (tbDirExe.Text == "")
                {
                    MessageBox.Show(rm.GetString("msgErrorBlank"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!SC.abrirScript(tbDirExe.Text, args))
                {
                    MessageBox.Show(rm.GetString("msgErrorOpen"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void cbArgs_CheckedChanged(object sender, EventArgs e)
        {
            switch (cbArgs.Checked)
            {
                case true:
                    tbArgsExe.Enabled = true;
                    break;
                case false:
                    tbArgsExe.Enabled = false;
                    break;
            }
        }

        private void btnCanc_Click(object sender, EventArgs e)
        {
            cancelarEjecutable();
            this.Close();
        }

        private void btnExmnr_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirEXE = new OpenFileDialog();
            abrirEXE.Title = string.Format(rm.GetString("textOFD"));
            abrirEXE.Filter = string.Format(rm.GetString("textEx"));
            Stream archivoEXE = null;
            if (abrirEXE.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (!abrirEXE.FileName.EndsWith(".EXE") && !abrirEXE.FileName.EndsWith(".exe"))
                    {
                        MessageBox.Show(string.Format(rm.GetString("msgErrorSE")), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if ((archivoEXE = abrirEXE.OpenFile()) != null)
                    {
                        using (archivoEXE)
                        {
                            tbDirExe.Text = abrirEXE.FileName;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(string.Format(rm.GetString("msgErrorOpen")), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbDirExe_TextChanged(object sender, EventArgs e)
        {
            if (tbDirExe.Text != "")
            {
                btnProbar.Enabled = true;
            }
            else
            {
                btnProbar.Enabled = false;
            }
        }
    }
}
