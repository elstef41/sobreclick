using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

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
            Application.EnableVisualStyles();
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException);
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
                acercade acercade = new acercade();
                acercade.TopMost = true;
                acercade.ShowDialog();
                Application.Exit();
            }
            catch
            {
                try
                {
                    acercade acercade = new acercade();
                    acercade.TopMost = true;
                    acercade.ShowDialog();
                    Application.Exit();
                }
                finally
                {
                    Application.Exit();
                }
            }
            Application.Exit();
        }
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            acercade acercade = new acercade();
            acercade.TopMost = true;
            acercade.ShowDialog();
            Application.Exit();
        }
    }
}
