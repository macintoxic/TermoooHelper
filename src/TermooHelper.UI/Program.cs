//Copyright (c) Charles Alves - Ceu System - Todos os direitos reservados.

using System;
using System.Windows.Forms;

namespace TermooHelper.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();

            Application.Run(new frmMain());
        }
    }
}