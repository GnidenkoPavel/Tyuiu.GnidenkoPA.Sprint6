using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Tuiu.GnidenkoPA.Sprint6.Task1.V18
{
    static class Program
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