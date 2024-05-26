using System.Diagnostics;
//---------------------------
using static Octopus.Configs;
using static Octopus.Imports;
//---------------------------

namespace Octopus
{
    class Minecraft
    {
        public static void Connect(System.Windows.Forms.Timer timer, Guna.UI2.WinForms.Guna2ProgressBar trackbar)
        {
            try { timer.Interval = 1005 / (trackbar.Value / 10); }
            catch { }

            Process[] processes = Process.GetProcessesByName("javaw");
            foreach (Process process in processes)
            {
                hWnd = FindWindow(null, process.MainWindowTitle);
            }
        }
    }
}
