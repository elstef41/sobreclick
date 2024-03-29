﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using static System.Resources.ResXFileRef;

namespace Sobreclick
{
    public partial class sc_config : Form
    {
        static conf Conf = new conf();
        public static TypeConverter conversor = TypeDescriptor.GetConverter(typeof(Keys));


        ResourceManager rm = new ResourceManager(typeof(sc_config));

        public static Keys iniT = (Keys)conversor.ConvertFromString(Conf.teclaIniciar());
        public static Keys pauT = (Keys)conversor.ConvertFromString(Conf.teclaPausarReanudar());
        public static Keys detT = (Keys)conversor.ConvertFromString(Conf.teclaDetener());
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
            if (iniT == pauT || iniT == detT || detT == pauT)
            {
                MessageBox.Show(rm.GetString("msgEqual"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                strings.actualizarTecla(1, iniT);
                strings.actualizarTecla(2, pauT);
                strings.actualizarTecla(3, detT);
                this.Close();
            }
        }

        private void sc_config_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.AppendText(iniT.ToString() + "\r\n");
            textBox2.AppendText(pauT.ToString() + "\r\n");
            textBox3.AppendText(detT.ToString() + "\r\n");
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
    }
}
