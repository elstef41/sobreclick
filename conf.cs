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
        public bool sonidoPredeterminado()
        {
            bool valor_predeterminado = false;
            bool.TryParse(ConfigurationManager.AppSettings.Get("sonidoPredeterminado"), out valor_predeterminado);
            return valor_predeterminado;
        }
        public bool sinLimiteCantidadIniciar()
        {
            bool valor_predeterminado = true;
            bool.TryParse(ConfigurationManager.AppSettings.Get("sinLimiteCantidadIniciar"), out valor_predeterminado);
            return valor_predeterminado;
        }
        public string dirSonido()
        {
            return ConfigurationManager.AppSettings.Get("dirSonido").Replace("/", "\\");
        }
    }
}
