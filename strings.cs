using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Media;
using System.Diagnostics;

namespace Sobreclick
{
    class strings
    {
        static conf Conf = new conf();
        public static Keys iniT = Keys.F6;
        public static Keys pauT = Keys.F7;
        public static Keys detT = Keys.F8;
        public static string archivoSonDir = Conf.dirSonido();
        public static SoundPlayer archivoSon = new SoundPlayer(archivoSonDir);
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

        public static void actualizarArchivoSon(string dirArchivo)
        {
            archivoSonDir = dirArchivo;
            SoundPlayer archivoSon = new SoundPlayer(archivoSonDir);
            Configuration configSave = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configSave.AppSettings.Settings["dirSonido"].Value = dirArchivo;
            configSave.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configSave.AppSettings.SectionInformation.Name);
        }

        public bool abrirScript(string dir, string args)
        {
            ProcessWindowStyle wst = ProcessWindowStyle.Normal;
            var proceso = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = dir,
                    WindowStyle = wst,
                    RedirectStandardOutput = false,
                    CreateNoWindow = true,
                    UseShellExecute = true,
                    Arguments = args
                }
            };
            try
            {
                proceso.Start();
                return true;
            }
            catch (SystemException err)
            {
                return false;
            }
        }
    }
}
