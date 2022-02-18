using System;
using System.Collections.Generic;
using System.Text;

namespace Sobreclick
{
    class strings
    {
        public string obtenerVersion()
        {
            string s = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Major.ToString() + "." + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString() + "." + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Build.ToString();
            return s;
        }
    }
}
