using System;
using System.Windows.Forms;
using Tyuiu.GnidenkoPA.Sprint6.Task0.V6;

namespace Tuiu.GnidenkoPA.Sprint6.Task0.V6
{
    internal static class Program 
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}