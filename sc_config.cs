using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using static System.Resources.ResXFileRef;
using System.Media;

namespace Sobreclick
{
    public partial class sc_config : Form
    {
        static conf Conf = new conf();
        public static TypeConverter conversor = TypeDescriptor.GetConverter(typeof(Keys));

        ResourceManager rm = new ResourceManager(typeof(sc_config));
        // Teclas
        public static Keys iniT = (Keys)conversor.ConvertFromString(Conf.teclaIniciar());
        public static Keys pauT = (Keys)conversor.ConvertFromString(Conf.teclaPausarReanudar());
        public static Keys detT = (Keys)conversor.ConvertFromString(Conf.teclaDetener());

        // Sonidos
        public static string sonConfDir = Conf.dirSonido();
        public static bool sonSistemaPreferido = false;

        public sc_config()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            button2.Enabled = true;
            textBox1.Clear();
            iniT = e.KeyCode;
            textBox1.AppendText(e.KeyCode.ToString() + "\r\n");
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            button2.Enabled = true;
            textBox2.Clear();
            pauT = e.KeyCode;
            textBox2.AppendText(e.KeyCode.ToString() + "\r\n");
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            button2.Enabled = true;
            textBox3.Clear();
            detT = e.KeyCode;
            textBox3.AppendText(e.KeyCode.ToString() + "\r\n");
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
                if (!checkBox1.Checked)
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
                if (!checkBox1.Checked)
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
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.AppendText(iniT.ToString() + "\r\n");
            textBox2.AppendText(pauT.ToString() + "\r\n");
            textBox3.AppendText(detT.ToString() + "\r\n");
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
                    button3.Enabled = true;
                    button4.Enabled = true;
                    sonSistemaPreferido = false;
                    break;
                case false:
                default:
                    textBox4.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    sonSistemaPreferido = true;
                    break;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            iniT = strings.iniT;
            pauT = strings.pauT;
            detT = strings.detT;
            textBox1.Clear();
            textBox1.AppendText(iniT.ToString() + "\r\n");
            textBox2.Clear();
            textBox2.AppendText(pauT.ToString() + "\r\n");
            textBox3.Clear();
            textBox3.AppendText(detT.ToString() + "\r\n");
            button2.Enabled = false;
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
            try
            {
                SoundPlayer testingSound = new SoundPlayer(textBox4.Text);
                testingSound.Play();
            }
            catch (Exception E)
            {
                MessageBox.Show(rm.GetString("msgErrorLoadingSound"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
