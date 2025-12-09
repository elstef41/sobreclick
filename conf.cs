using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Xml;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace Sobreclick
{
    class conf
    {
        // Valores predefinidos, según cada parámetro configurable del programa
        string tecla_iniciar = "F6";
        string tecla_pausar_reanudar = "F7";
        string tecla_detener = "F8";
        string dir_sonido = "C:\\Windows\\Media\\notify.wav";
        bool sonido_predeterminado = false;
        bool sin_limite_cantidad_iniciar = true;

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
            bool valor_predeterminado = sonido_predeterminado;
            bool.TryParse(ConfigurationManager.AppSettings.Get("sonidoPredeterminado"), out valor_predeterminado);
            return valor_predeterminado;
        }
        public bool sinLimiteCantidadIniciar()
        {
            bool valor_predeterminado = sin_limite_cantidad_iniciar;
            bool.TryParse(ConfigurationManager.AppSettings.Get("sinLimiteCantidadIniciar"), out valor_predeterminado);
            return valor_predeterminado;
        }
        public string dirSonido()
        {
            return ConfigurationManager.AppSettings.Get("dirSonido").Replace("/", "\\");
        }
    }
}
