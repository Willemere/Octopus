using System.Windows.Forms;

namespace Octopus
{
    class Page
    {
        public static readonly RightClicker RightClicker = new RightClicker();

        public static readonly LeftClicker LeftClicker = new LeftClicker();

        public static readonly Settings Settings = new Settings();

        public static void addUserControl(Panel panel, UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(userControl);
            userControl.BringToFront();
        }
    }
}
