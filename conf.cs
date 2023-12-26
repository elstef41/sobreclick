using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Xml;
using System.Windows.Forms;
using System.IO;

namespace Sobreclick
{
    class conf
    {
        public conf()
        {
            if (!File.Exists(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile ))
            {
                MessageBox.Show(sobreclick.rm.GetString("errorLoadingConfigFile"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(0);
            }
        }
        public string teclaIniciar()
        {
            return ConfigurationManager.AppSettings.Get("iniciar");
        }
        public string teclaPausarReanudar()
        {
            return ConfigurationManager.AppSettings.Get("pausarReanudar");
        }
        public string teclaDetener()
        {
            return ConfigurationManager.AppSettings.Get("detener");
        }
        public string dirSonido()
        {
            return ConfigurationManager.AppSettings.Get("dirSonido");
        }
    }
}
