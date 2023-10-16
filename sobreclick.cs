using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Globalization;
using System.Resources;
using static System.Resources.ResXFileRef;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Diagnostics;
using System.Media;

namespace Sobreclick
{
    public partial class sobreclick : Form
    {
        strings SC = new strings();
        static conf Conf = new conf();
        public static TypeConverter conversor = TypeDescriptor.GetConverter(typeof(Keys));

        // Variables genéricas
        public static bool sonidoAT = false;
        public static bool apagarAT = false;
        public static bool salirAT = false;
        public static bool ejecutarScriptAT = false;

        public ProcessStartInfo shutdownProcess = new ProcessStartInfo("shutdown", "-s -t 0");

        ResourceManager rm = new ResourceManager(typeof(sobreclick));
        private const int MOUSEEVENTF_LEFTDOWN = 0X0002;
        private const int MOUSEEVENTF_LEFTUP = 0X0004;
        private const int MOUSEEVENTF_MIDDLEDOWN = 0X0020;
        private const int MOUSEEVENTF_MIDDLEUP = 0X0040;
        private const int MOUSEEVENTF_RIGHTDOWN = 0X0008;
        private const int MOUSEEVENTF_RIGHTUP = 0X00010;

        private const int tclidi = 0x0997;
        private const int tclidp = 0x0998;
        private const int tclidd = 0x0999;
        
        Keys tcli = strings.iniT;
        Keys tclp = strings.pauT;
        Keys tcld = strings.detT;

        string sonDir = strings.archivoSonDir;
        string scriptAT;


        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);


        int clickTimes = 0;
        public void ClickI()
        {
            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }

        public void ClickM()
        {
            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_MIDDLEDOWN | MOUSEEVENTF_MIDDLEUP, X, Y, 0, 0);
        }

        public void ClickD()
        {
            //Call the imported function with the cursor's current position
            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
        }

        public sobreclick()
        {
            InitializeComponent();
            this.Text = "Sobreclick ";
            this.Text += SC.obtenerVersion();
            this.Text += " por elstef41";
            this.MinimumSize = new Size(270, 268);
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        public void actualizarDirSon()
        {
            sonDir = Conf.dirSonido();
            if (sonDir == null)
            {
                MessageBox.Show(rm.GetString("msgConfError0"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                configuraciónToolStripMenuItem.Enabled = false;
            }
        }

        public void actualizarTeclas()
        {
            UnregisterHotKey(this.Handle, tclidi);
            UnregisterHotKey(this.Handle, tclidp);
            UnregisterHotKey(this.Handle, tclidd);

            try
            {
                tcli = (Keys)conversor.ConvertFromString(Conf.teclaIniciar());
                tclp = (Keys)conversor.ConvertFromString(Conf.teclaPausarReanudar());
                tcld = (Keys)conversor.ConvertFromString(Conf.teclaDetener());
            }
            catch (Exception e)
            {
                MessageBox.Show(rm.GetString("msgConfError0"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                configuraciónToolStripMenuItem.Enabled = false;
            }

            RegisterHotKey(this.Handle, tclidi, 0x0000, (int)tcli);
            RegisterHotKey(this.Handle, tclidp, 0x0000, (int)tclp);
            RegisterHotKey(this.Handle, tclidd, 0x0000, (int)tcld);
            switch (CultureInfo.CurrentCulture.Name)
            {
                case "en":
                    buttonC.Text = buttonC.Text.Substring(0, 7) + tcli.ToString() + ")";
                    buttonR.Text = buttonR.Text.Substring(0, 8) + tclp.ToString() + ")";
                    buttonP.Text = buttonP.Text.Substring(0, 7) + tclp.ToString() + ")";
                    buttonD.Text = buttonD.Text.Substring(0, 6) + tcld.ToString() + ")";
                    break;
                case "es-ES":
                default:
                    buttonC.Text = buttonC.Text.Substring(0, 10) + tcli.ToString() + ")";
                    buttonR.Text = buttonR.Text.Substring(0, 11) + tclp.ToString() + ")";
                    buttonP.Text = buttonP.Text.Substring(0, 9) + tclp.ToString() + ")";
                    buttonD.Text = buttonD.Text.Substring(0, 10) + tcld.ToString() + ")";
                    break;
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0x0312)
            {
                switch (m.WParam.ToInt32())
                {
                    case tclidi:
                        if (buttonC.Enabled)
                        {
                            clickTimes = Convert.ToInt32(numericUpDown1.Value);
                            Iniciar();
                        }
                        break;
                    case tclidp:
                        if (!buttonC.Enabled)
                        {
                            if (!buttonR.Enabled)
                            {
                                Pausar();
                            }
                            else
                            {
                                Reanudar();
                            }
                        }
                        else
                        {
                            buttonP.Visible = true;
                        }
                        break;
                    case tclidd:
                        if (buttonD.Enabled)
                        {
                            Detener();
                        }
                        break;
                }
            }

        }
        private void ascercaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new acercade().ShowDialog();
        }

        private void licenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.apache.org/licenses/LICENSE-2.0.html");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void cambiarTextStatus(string texto, int intervalo)
        {
            timerStatus.Stop();
            if (intervalo != 0)
            {
                timerStatus.Interval = intervalo;
                timerStatus.Start();
            }
            statusText.Text = texto;
        }
        public bool Iniciar()
        {
            bool nud1 = Convert.ToInt32(numericUpDown1.Value) < 1;
            if (nud1 == true)
            {
                MessageBox.Show(rm.GetString("msgMore0"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show(rm.GetString("msgClickType"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                int clickinterval;
                switch (Convert.ToInt32(comboBox2.SelectedIndex))
                {
                    case 0:
                        // Milisegundos
                        clickinterval = Convert.ToInt32(numericUpDown2.Value);
                        break;
                    case 1:
                        // Segundos
                        clickinterval = Convert.ToInt32(numericUpDown2.Value) * 1000;
                        break;
                    case 2:
                        // Minutos
                        clickinterval = Convert.ToInt32(numericUpDown2.Value) * 60000;
                        break;
                    case 3:
                        // Horas
                        clickinterval = Convert.ToInt32(numericUpDown2.Value) * 3600000;
                        break;
                    default:
                        clickinterval = Convert.ToInt32(numericUpDown2.Value);
                        break;
                }
                buttonC.Enabled = false;
                buttonP.Enabled = true;
                buttonD.Enabled = true;
                timerClick.Interval = clickinterval;
                timerClick.Start();
                cambiarTextStatus("", 0);
                return true;
            }
        }

        public bool Detener()
        {
            buttonC.Enabled = true;
            buttonP.Visible = true;
            buttonP.Enabled = false;
            buttonD.Enabled = false;
            buttonR.Visible = false;
            buttonR.Enabled = false;
            timerClick.Dispose();   

            if (sonidoAT)
            {
                try
                {
                    SoundPlayer archivoSon = new SoundPlayer(Conf.dirSonido());
                    archivoSon.Play();
                }
                catch (Exception e)
                {
                    MessageBox.Show(rm.GetString("msgSoundError"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (apagarAT)
            {
                try
                {
                    shutdownProcess.CreateNoWindow = true;
                    shutdownProcess.UseShellExecute = false;
                    Process.Start(shutdownProcess);
                }
                catch (Exception e)
                {
                    MessageBox.Show(rm.GetString("msgShutdownError"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (salirAT)
            {
                this.Dispose();
            }
            cambiarTextStatus(rm.GetString("statusEnded"), 5000);
            return true;
        }

        public bool Reanudar()
        {
            buttonP.Visible = true;
            buttonP.Enabled = true;
            buttonR.Visible = false;
            buttonR.Enabled = false;
                int clickinterval;
                switch (Convert.ToInt32(comboBox2.SelectedIndex))
                {
                    case 0:
                        clickinterval = Convert.ToInt32(numericUpDown2.Value);
                        break;
                    case 1:
                        clickinterval = Convert.ToInt32(numericUpDown2.Value) * 1000;
                        break;
                    case 2:
                        clickinterval = Convert.ToInt32(numericUpDown2.Value) * 60000;
                        break;
                    case 3:
                        clickinterval = Convert.ToInt32(numericUpDown2.Value) * 3600000;
                        break;
                    default:
                        clickinterval = Convert.ToInt32(numericUpDown2.Value);
                        break;
                }
                timerClick.Interval = clickinterval;
            timerClick.Start();
            cambiarTextStatus("", 0);
            return true;
        }

        public bool Pausar()
        {
            buttonP.Visible = false;
            buttonR.Visible = true;
            buttonR.Enabled = true;
            timerClick.Interval = Convert.ToInt32(numericUpDown2.Value);
            timerClick.Stop();
            cambiarTextStatus(rm.GetString("statusPaused"), 0);
            return true;
        }



        private void buttonC_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Text == "")
            {
                MessageBox.Show(rm.GetString("msgTimeSelection"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numericUpDown2.Text == "")
            {
                MessageBox.Show(rm.GetString("msgTypeSelection"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                clickTimes = Convert.ToInt32(numericUpDown1.Value);
                Iniciar();
            }
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            Detener();
            buttonP.Visible = true;
            buttonP.Enabled = false;
            buttonR.Visible = false;
            buttonR.Enabled = false;
        }

        private void timerClick_Tick(object sender, EventArgs e)
        {
            switch (checkBox1.Checked)
            {
                case true:
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0:
                            if (checkBox2.Checked) { ClickI(); }
                            ClickI();
                            break;
                        case 1:
                            if (checkBox2.Checked) { ClickM(); }
                            ClickM();
                            break;
                        case 2:
                            if (checkBox2.Checked) { ClickD(); }
                            ClickD();
                            break;
                    }
                        break;
                case false:
                    if (clickTimes != 0)
                    {
                        switch (comboBox1.SelectedIndex)
                        {
                            case 0:
                                if (checkBox2.Checked) { ClickI(); }
                                ClickI();
                                break;
                            case 1:
                                if (checkBox2.Checked) { ClickM(); }
                                ClickM();
                                break;
                            case 2:
                                if (checkBox2.Checked) { ClickD(); }
                                ClickD();
                                break;
                        }
                        clickTimes--;
                    }
                    else
                    {
                        Detener();
                        if (cerrarAlTerminarToolStripMenuItem.Checked) { this.Dispose(); }
                    }
                    break;
            }
            
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            Pausar();
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            Reanudar();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox1.Checked)
            {
                case true:
                    numericUpDown1.Enabled = false;
                    break;
                case false:
                    numericUpDown1.Enabled = true;
                    break;
            }
        }

        private void restaurarValoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            numericUpDown2.Enabled = true;
            numericUpDown1.Value = 10;
            numericUpDown2.Value = 500;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            restaurarValoresToolStripMenuItem.Enabled = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 10)
            {
                restaurarValoresToolStripMenuItem.Enabled = true;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int tiempoTotal = Convert.ToInt32(numericUpDown2.Value);
            int miliASegundos = Convert.ToInt32(numericUpDown2.Value) / 1000;
            int miliAMinutos = Convert.ToInt32(numericUpDown2.Value) / 60000;
            int segundosAMinutos = Convert.ToInt32(numericUpDown2.Value) / 60;
            if (numericUpDown2.Value != 500)
            {
                restaurarValoresToolStripMenuItem.Enabled = true;
            }
            int clickinterval;
            switch (Convert.ToInt32(comboBox2.SelectedIndex))
            {
                case 0:
                    // Milisegundos
                    clickinterval = Convert.ToInt32(numericUpDown2.Value);
                    cambiarTextStatus(rm.GetString("statusEstimatedTime0") + miliASegundos.ToString() + ((miliASegundos == 1) ? rm.GetString("statusEstimatedTime1NP") : rm.GetString("statusEstimatedTime1")) + miliAMinutos.ToString() + ((miliAMinutos == 1) ? rm.GetString("statusEstimatedTime2NP") : rm.GetString("statusEstimatedTime2")), 0);
                    break;
                case 1:
                    // Milisegundos
                    clickinterval = Convert.ToInt32(numericUpDown2.Value);
                    cambiarTextStatus(rm.GetString("statusEstimatedTime0") + segundosAMinutos.ToString() + ((segundosAMinutos == 1) ? rm.GetString("statusEstimatedTime2NP") : rm.GetString("statusEstimatedTime2")), 0);
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
                restaurarValoresToolStripMenuItem.Enabled = true;
            }
        }

        private void sobreclick_Load(object sender, EventArgs e)
        {
            clickTimes = Convert.ToInt32(numericUpDown1.Value);
            actualizarDirSon();
            actualizarTeclas();
        }

        private void visitarRepositorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(strings.scRepositorio);
        }

        private void siempreVisibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!siempreVisibleToolStripMenuItem.Checked)
            {
                this.TopMost = true;
                siempreVisibleToolStripMenuItem.Checked = true;
            }
            else
            {
                this.TopMost = false;
                siempreVisibleToolStripMenuItem.Checked = false;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != 0)
            {
                restaurarValoresToolStripMenuItem.Enabled = true;
            }
            cambiarTextStatus("", 0);
        }


        private static void ChangeLanguage(string lang)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            foreach (Form frm in Application.OpenForms)
            {
                localizeForm(frm);
            }
        }

        private static void localizeForm(Form frm)
        {
            var manager = new ComponentResourceManager(frm.GetType());
            manager.ApplyResources(frm, "$this");
            applyResources(manager, frm.Controls);
        }

        private static void applyResources(ComponentResourceManager manager, Control.ControlCollection ctls)
        {
            foreach (Control ctl in ctls)
            {
                manager.ApplyResources(ctl, ctl.Name);
                applyResources(manager, ctl.Controls);
            }
        }
          

        private void siempreVisibleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (!siempreVisibleToolStripMenuItem.Checked)
            {
                this.TopMost = true;
                siempreVisibleToolStripMenuItem.Checked = true;
            }
            else
            {
                this.TopMost = false;
                siempreVisibleToolStripMenuItem.Checked = false;
            }
        }


        private void restaurarTamañoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(285, 287);
            restaurarTamañoToolStripMenuItem.Enabled = false;
        }

        private void sobreclick_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                restaurarTamañoToolStripMenuItem.Enabled = false;

            }
            else if (this.Size.Width != 287 || this.Size.Height != 285)
            {
                restaurarTamañoToolStripMenuItem.Enabled = true;
            }
            else
            {
                restaurarTamañoToolStripMenuItem.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                restaurarValoresToolStripMenuItem.Enabled = true;
            }
            else
            {
                restaurarValoresToolStripMenuItem.Enabled = false;
            }
        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sc_config scC = new sc_config();
            scC.Show();
            scC.FormClosed += new FormClosedEventHandler(scC_FormClosed);
        }

        private void scC_FormClosed(object sender, FormClosedEventArgs e)
        {
            actualizarTeclas();
        }
        private void sobreclick_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, tclidi);
            UnregisterHotKey(this.Handle, tclidp);
            UnregisterHotKey(this.Handle, tclidd);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            actualizarTeclas();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (salirToolStripMenuItem1.Checked)
            {
                salirAT = true;
            }
            else
            {
                salirAT = false;
            }
        }

        private void reproducirSonidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (reproducirSonidoToolStripMenuItem.Checked)
            {
                sonidoAT = true;
            }
            else
            {
                sonidoAT = false;
            }
        }

        private void apagarElEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (apagarElEquipoToolStripMenuItem.Checked)
            {
                apagarAT = true;
            }
            else
            {
                apagarAT = false;
            }
        }

        private void timerStatus_Tick(object sender, EventArgs e)
        {
            statusText.Text = "";
            timerStatus.Stop();
        }

    }
}
