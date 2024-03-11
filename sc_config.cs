using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Media;

namespace Sobreclick
{
    public partial class sc_config : Form
    {
        // Variables
        static conf Conf = new conf();
        public static TypeConverter conversor = TypeDescriptor.GetConverter(typeof(Keys));
        SoundPlayer testingSound;


        ResourceManager rm = new ResourceManager(typeof(sc_config));

        // Teclas
        public static Keys iniT;
        public static Keys pauT;
        public static Keys detT;

        // Sonidos
        public static string sonConfDir = Conf.dirSonido();
        public static bool sonSistemaPreferido = false;

        public sc_config()
        {
            InitializeComponent();
        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            btnRestaurar.Enabled = true;
            tbIni.Clear();
            iniT = e.KeyCode;
            tbIni.AppendText(e.KeyCode.ToString() + "\r\n");
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            btnRestaurar.Enabled = true;
            tbPR.Clear();
            pauT = e.KeyCode;
            tbPR.AppendText(e.KeyCode.ToString() + "\r\n");
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            btnRestaurar.Enabled = true;
            pbDen.Clear();
            detT = e.KeyCode;
            pbDen.AppendText(e.KeyCode.ToString() + "\r\n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sonConfDir = textBox4.Text;
            if (iniT == pauT || iniT == detT || detT == pauT)
            {
                MessageBox.Show(rm.GetString("msgEqual"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!cbSonidosSistema.Checked)
                {
                    if (sonConfDir == "")
                    {
                        DialogResult confirmSon = MessageBox.Show(rm.GetString("msgSonDefault"), "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        switch (confirmSon)
                        {
                            case DialogResult.Yes:
                                guardarCambiosConf();
                                break;
                        }
                    }
                    else
                    {
                        guardarCambiosConf();
                    }
                }
                else
                {
                    guardarCambiosConf();
                }
            }
        }

        private void guardarCambiosConf()
        {
            try
            {
                strings.actualizarTecla(1, iniT);
                strings.actualizarTecla(2, pauT);
                strings.actualizarTecla(3, detT);
                if (!cbSonidosSistema.Checked)
                {
                    strings.actualizarArchivoSon(sonConfDir);
                }
                else
                {
                    strings.actualizarArchivoSon(@"C:\Windows\Media\chord.wav");
                }
                this.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(rm.GetString("msgErrorSaving"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sc_config_Load(object sender, EventArgs e)
        {
            tbIni.Clear();
            tbPR.Clear();
            pbDen.Clear();
            textBox4.Clear();

            // Cargar variables de teclas
            iniT = (Keys)conversor.ConvertFromString(Conf.teclaIniciar());
            pauT = (Keys)conversor.ConvertFromString(Conf.teclaPausarReanudar());
            detT = (Keys)conversor.ConvertFromString(Conf.teclaDetener());

            tbIni.AppendText(iniT.ToString() + "\r\n");
            tbPR.AppendText(pauT.ToString() + "\r\n");
            pbDen.AppendText(detT.ToString() + "\r\n");
            textBox4.AppendText(sonConfDir + "\r\n");
            if (sonConfDir == "")
            {
                turnarConfigSonido();
            }
        }

        private void turnarConfigSonido()
        {
            switch (sonSistemaPreferido)
            {
                case true:
                    textBox4.Enabled = true;
                    btnExmnr.Enabled = true;
                    sonSistemaPreferido = false;
                    break;
                case false:
                default:
                    textBox4.Enabled = false;
                    btnExmnr.Enabled = false;
                    sonSistemaPreferido = true;
                    break;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            iniT = strings.iniT;
            pauT = strings.pauT;
            detT = strings.detT;
            tbIni.Clear();
            tbIni.AppendText(iniT.ToString() + "\r\n");
            tbPR.Clear();
            tbPR.AppendText(pauT.ToString() + "\r\n");
            pbDen.Clear();
            pbDen.AppendText(detT.ToString() + "\r\n");
            btnRestaurar.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            turnarConfigSonido();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog cargarSon = new OpenFileDialog())
            {
                cargarSon.Filter = "WaveForm Audio Format (*.wav)|*.wav";
                if (cargarSon.ShowDialog() == DialogResult.OK && cargarSon.FileName.EndsWith(".wav"))
                {
                    var fs = cargarSon.OpenFile();
                    textBox4.Text = cargarSon.FileName;
                }
                else
                {
                    MessageBox.Show(rm.GetString("msgErrorLoadingSound"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sonConfDir = textBox4.Text;

            switch (sonSistemaPreferido)
            {
                case true:
                    testingSound = new SoundPlayer(@"C:\Windows\Media\chord.wav");
                    break;
                case false:
                    testingSound = new SoundPlayer(sonConfDir);
                    break;
            }
            try
            {
                testingSound.Play();
            }
            catch (Exception E)
            {
                MessageBox.Show(rm.GetString("msgErrorLoadingSound"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sc_config_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (testingSound != null)
            {
                testingSound.Stop();
            }
            this.Dispose();
        }
    }
}
