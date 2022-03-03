using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Globalization;

namespace Sobreclick
{
    public partial class sobreclick : Form
    {
        strings SC = new strings();
        private const int MOUSEEVENTF_LEFTDOWN = 0X0002;
        private const int MOUSEEVENTF_LEFTUP = 0X0004;
        private const int MOUSEEVENTF_MIDDLEDOWN = 0X0020;
        private const int MOUSEEVENTF_MIDDLEUP = 0X0040;
        private const int MOUSEEVENTF_RIGHTDOWN = 0X0008;
        private const int MOUSEEVENTF_RIGHTUP = 0X00010;

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        

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
            int tcli = (int)Keys.F6;
            int tclidi = 1;
            int tclp = (int)Keys.F7;
            int tclidp = 2;
            int tcld = (int)Keys.F8;
            int tclidd = 3;
            Boolean F6P = RegisterHotKey(
                    this.Handle, tclidi, 0x0000, tcli
                );
            Boolean F7P = RegisterHotKey(
                    this.Handle, tclidp, 0x0000, tclp
                );
            Boolean F8P = RegisterHotKey(
                    this.Handle, tclidd, 0x0000, tcld
                );
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312)
            {
                int i = m.WParam.ToInt32();

                switch (i)
                {
                    case 1:
                        if (buttonC.Enabled)
                        {
                            clickTimes = Convert.ToInt32(numericUpDown1.Value);
                            Iniciar();
                        }
                        break;
                    case 2:
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
                    case 3:
                        if (buttonD.Enabled)
                        {
                            Detener();
                        }
                        break;
                }
            }

            base.WndProc(ref m);
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


        public bool Iniciar()
        {
            bool nud1 = Convert.ToInt32(numericUpDown1.Value) < 1;
            if (nud1 == true)
            {
                MessageBox.Show("La cantidad de clics debe ser mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Selecciona un tipo de clic: izquierdo, central o derecho.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
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
                buttonC.Enabled = false;
                buttonP.Enabled = true;
                buttonD.Enabled = true;
                timerClick.Interval = clickinterval;
                timerClick.Start();
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
            return true;
        }

        public bool Pausar()
        {
            buttonP.Visible = false;
            buttonR.Visible = true;
            buttonR.Enabled = true;
            timerClick.Interval = Convert.ToInt32(numericUpDown2.Value);
            timerClick.Stop();
            return true;
        }


        private void buttonC_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Text == "")
            {
                MessageBox.Show("Tienes que establecer una duración.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numericUpDown2.Text == "")
            {
                MessageBox.Show("Tienes que establecer un tipo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (cerrarAlTerminarToolStripMenuItem.Checked) { this.Dispose(); }
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
            if (numericUpDown2.Value != 500)
            {
                restaurarValoresToolStripMenuItem.Enabled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
                restaurarValoresToolStripMenuItem.Enabled = true;
            }
        }

        private void cerrarAlTerminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!cerrarAlTerminarToolStripMenuItem.Checked)
            {
                cerrarAlTerminarToolStripMenuItem.Checked = true;
            }
            else
            {
                cerrarAlTerminarToolStripMenuItem.Checked = false;
            }
        }

        private void sobreclick_Load(object sender, EventArgs e)
        {
            clickTimes = Convert.ToInt32(numericUpDown1.Value);
        }

        private void visitarRepositorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/elstef41/sobreclick");
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

        private void languageToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    }
}
