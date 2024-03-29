﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using static System.Resources.ResXFileRef;
using System.ComponentModel;
using System.Net.NetworkInformation;

namespace Sobreclick
{
    class strings
    {
        public static Keys iniT = Keys.F6;
        public static Keys pauT = Keys.F7;
        public static Keys detT = Keys.F8;
        public static string scRepositorio = "https://github.com/elstef41/sobreclick";
        public string obtenerVersion()
        {
            string s = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Major.ToString() + "." + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString() + "." + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Build.ToString();
            return s;
        }
        public static Keys getKey(Keys k)
        {
            return k;
        }
        public static void actualizarTecla(int tipo, Keys tecla)
        {
            Configuration configSave = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            switch (tipo)
            {
                case 1:
                    iniT = tecla;
                    configSave.AppSettings.Settings["iniciar"].Value = tecla.ToString();
                    configSave.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection(configSave.AppSettings.SectionInformation.Name);
                    break;
                case 2:
                    pauT = tecla;
                    configSave.AppSettings.Settings["pausarReanudar"].Value = tecla.ToString();
                    configSave.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection(configSave.AppSettings.SectionInformation.Name);
                    break;
                case 3:
                    detT = tecla;
                    configSave.AppSettings.Settings["detener"].Value = tecla.ToString();
                    configSave.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection(configSave.AppSettings.SectionInformation.Name);
                    break;
            }
        }
    }
}
