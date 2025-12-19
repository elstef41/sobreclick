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
        bool confInicialComprobada = false;
        bool confSinLimiteIniciar = false;

        ResourceManager rm = new ResourceManager(typeof(sc_config));

        // Teclas
        public static Keys iniT;
        public static Keys pauT;
        public static Keys detT;

        // Sonidos
        public static string sonConfDir = Conf.dirSonido();
        public static bool sonSistemaPreferido = Conf.sonidoPredeterminado();
        public static bool sonSinLimiteIniciar = Conf.sinLimiteCantidadIniciar();

        public sc_config()
        {
            InitializeComponent();
        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            btnRestaurar.Enabled = true;
            tbIni.Clear();
            iniT = e.KeyCode;
            tbIni.AppendText(e.KeyCode.ToString());
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            btnRestaurar.Enabled = true;
            tbPR.Clear();
            pauT = e.KeyCode;
            tbPR.AppendText(e.KeyCode.ToString());
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            btnRestaurar.Enabled = true;
            pbDen.Clear();
            detT = e.KeyCode;
            pbDen.AppendText(e.KeyCode.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sonConfDir = tbSoundDir.Text;
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

        private void reestablecerCambiosConf()
        {
            // Actualizar datos de configuración
            strings.actualizarTecla(1, Conf.tecla_iniciar);
            strings.actualizarTecla(2, Conf.tecla_pausar_reanudar);
            strings.actualizarTecla(3, Conf.tecla_detener);
            strings.actualizarArchivoSon(Conf.dir_sonido);
            strings.actualizarAjusteBooleano("sonidoPredeterminado", Conf.sonido_predeterminado);
            strings.actualizarAjusteBooleano("sinLimiteCantidadIniciar", Conf.sin_limite_cantidad_iniciar);

            sonConfDir = Conf.dirSonido();
            sonSistemaPreferido = Conf.sonidoPredeterminado();
            sonSinLimiteIniciar = Conf.sinLimiteCantidadIniciar();

            // Recambiar en form
            btnRestaurar.Enabled = false;
            cargarConf();
        }
        private void guardarCambiosConf()
        {
            try
            {
                strings.actualizarTecla(1, iniT);
                strings.actualizarTecla(2, pauT);
                strings.actualizarTecla(3, detT);
                strings.actualizarArchivoSon(sonConfDir);
                switch (cbSonidosSistema.Checked)
                {
                    case true:
                        sonSistemaPreferido = true;
                        break;
                    case false:
                    default:
                        sonSistemaPreferido = false;
                        break;
                }
                switch (cbSinLimiteIniciar.Checked)
                {
                    case true:
                        sonSinLimiteIniciar = true;
                        break;
                    case false:
                    default:
                        sonSinLimiteIniciar = false;
                        break;
                }
                strings.actualizarAjusteBooleano("sonidoPredeterminado", sonSistemaPreferido);
                strings.actualizarAjusteBooleano("sinLimiteCantidadIniciar", sonSinLimiteIniciar);
                strings.actualizarSonidoPredeterminado(sonSistemaPreferido);
                this.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(rm.GetString("msgErrorSaving"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sc_config_Load(object sender, EventArgs e)
        {
            // Cargar configuración
            cargarConf();
        }

        private void cargarConf()
        {
            tbIni.Clear();
            tbPR.Clear();
            pbDen.Clear();
            tbSoundDir.Clear();

            // Cargar variables de teclas
            iniT = (Keys)conversor.ConvertFromString(Conf.teclaIniciar());
            pauT = (Keys)conversor.ConvertFromString(Conf.teclaPausarReanudar());
            detT = (Keys)conversor.ConvertFromString(Conf.teclaDetener());

            tbIni.AppendText(iniT.ToString());
            tbPR.AppendText(pauT.ToString());
            pbDen.AppendText(detT.ToString());
            tbSoundDir.AppendText(sonConfDir);
            this.tbSoundDir.TextChanged += new System.EventHandler(this.tbSoundDir_TextChanged);

            // Hacer detección de archivo de configuración
            verificarConfSonido();

            confInicialComprobada = true;
        }
        private void verificarConfSonido()
        {
            switch (sonSistemaPreferido)
            {
                case true:
                    tbSoundDir.Enabled = false;
                    btnExmnr.Enabled = false;
                    cbSonidosSistema.Checked = true;
                    break;
                case false:
                default:
                    tbSoundDir.Enabled = true;
                    btnExmnr.Enabled = true;
                    cbSonidosSistema.Checked = false;
                    break;
            }
            cbSinLimiteIniciar.Checked = sonSinLimiteIniciar;
        }

        private void turnarConfigSonido()
        {
            switch (sonSistemaPreferido)
            {
                case true:
                    cbSonidosSistema.Checked = false;
                    tbSoundDir.Enabled = true;
                    btnExmnr.Enabled = true;
                    sonSistemaPreferido = false;
                    break;
                case false:
                default:
                    cbSonidosSistema.Checked = true;
                    tbSoundDir.Enabled = false;
                    btnExmnr.Enabled = false;
                    sonSistemaPreferido = true;
                    break;
            }
        }

        public void cargarArchivoSonido()
        {
            using (OpenFileDialog cargarSon = new OpenFileDialog())
            {
                cargarSon.Filter = "WaveForm Audio Format (*.wav)|*.wav";
                DialogResult resultadoCarga = cargarSon.ShowDialog();
                if (resultadoCarga == DialogResult.OK && cargarSon.FileName.EndsWith(".wav"))
                {
                    if (cargarSon.FileName.EndsWith(".wav"))
                    {
                        var fs = cargarSon.OpenFile();
                        tbSoundDir.Text = cargarSon.FileName;
                    }
                    else
                    {
                        MessageBox.Show(rm.GetString("msgErrorLoadingSound"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            iniT = strings.iniT;
            pauT = strings.pauT;
            detT = strings.detT;
            tbIni.Clear();
            tbIni.AppendText(iniT.ToString());
            tbPR.Clear();
            tbPR.AppendText(pauT.ToString());
            pbDen.Clear();
            pbDen.AppendText(detT.ToString());
            tbSoundDir.Clear();
            tbSoundDir.AppendText(sonConfDir);
            btnRestaurar.Enabled = false;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            switch (confInicialComprobada)
            {
                case true:
                    turnarConfigSonido();
                    break;
                case false:
                default:
                    confInicialComprobada = true;
                    break;
            }
        }

        private void btnExmnr_Click(object sender, EventArgs e)
        {
            cargarArchivoSonido();
        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            sonConfDir = tbSoundDir.Text.Replace("/", "\\");

            switch (sonSistemaPreferido)
            {
                case true:
                    // TODO: Parametrizar sonido predeterminado
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

        private void tbSoundDir_TextChanged(object sender, EventArgs e)
        {
            if (confInicialComprobada == true)
            {
                btnRestaurar.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            switch (confSinLimiteIniciar)
            {
                case true:
                    confSinLimiteIniciar = true;
                    break;
                case false:
                default:
                    confSinLimiteIniciar = false;
                    break;
            }
        }

        private void btnValoresPredeterminados_Click(object sender, EventArgs e)
        {
            DialogResult confirmValoresPredeterminados = MessageBox.Show(rm.GetString("msgValoresPredeterminados"), "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (confirmValoresPredeterminados)
            {
                case DialogResult.Yes:
                    confInicialComprobada = false; // TODO: Buscar una manera de emprolijar la detección
                    reestablecerCambiosConf();
                    break;
            }
        }
    }
}
