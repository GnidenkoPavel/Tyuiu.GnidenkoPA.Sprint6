using System;
using System.Windows.Forms;
using Tyuiu.GnidenkoPA.Sprint6.Task4.V9;

namespace Tuiu.GnidenkoPA.Sprint6.Task4.V9
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}