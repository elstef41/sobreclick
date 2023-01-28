using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Sobreclick
{
    class strings
    {
        public static Keys iniT = Keys.F6;
        public static Keys pauT = Keys.F7;
        public static Keys detT = Keys.F8;
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
            switch (tipo)
            {
                case 1:
                    iniT = tecla;
                    break;
                case 2:
                    pauT = tecla;
                    break;
                case 3:
                    detT = tecla;
                    break;
            }
        }
    }
}
