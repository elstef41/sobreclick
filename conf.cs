using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Xml;
namespace Sobreclick
{
    class conf
    {
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
    }
}
