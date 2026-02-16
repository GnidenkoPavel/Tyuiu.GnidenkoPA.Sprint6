using System;
using System.Windows.Forms;
using Tyuiu.GnidenkoPA.Sprint6.Task1.V18;
using Tyuiu.GnidenkoPA.Sprint6.Task1.V18.Lib;
namespace Tuiui.GnidenkoPA.Sprint6.Task1.V18
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