using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;

namespace Sobreclick
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Comprobar existencia de archivos internos
            if (!File.Exists(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile))
            {
                MessageBox.Show(sobreclick.rm.GetString("errorLoadingConfigFile"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(0);
            }
            Application.EnableVisualStyles();
            Application.ThreadException += new ThreadExceptionEventHandler(UIThreadException);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new sobreclick());
        }

        // Controlador de excepciones casero
        private static void UIThreadException(object sender, ThreadExceptionEventArgs e)
        {
            try
            {
                excpt exception = new excpt(e.Exception.ToString());
                exception.TopMost = true;
                exception.ShowDialog();
                Application.ExitThread();
                Application.Exit();
            }
            catch
            {
                try
                {
                    excpt exception = new excpt(e.Exception.ToString());
                    exception.TopMost = true;
                    exception.ShowDialog();
                    Application.Exit();
                }
                finally
                {
                    Application.ExitThread();
                    Application.Exit();
                }
            }
            Application.ExitThread();
            Application.Exit();
        }
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            excpt exception = new excpt(e.ExceptionObject.ToString());
            exception.TopMost = true;
            exception.ShowDialog();
            Application.ExitThread();
            Application.Exit();
        }
    }
}
