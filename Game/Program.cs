using System;
using System.Drawing;
using System.Windows.Forms;

namespace Game
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var game = new GameForm();
            Application.Run(game);
        }
    }
}