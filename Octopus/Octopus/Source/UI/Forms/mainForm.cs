using System;
using System.Windows.Forms;
using System.Windows.Media;
//---------------------------
using static Octopus.Configs;
using static Octopus.Page;
//---------------------------

namespace Octopus
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();

            Keyboard.Install();

            var Octopus = new MediaPlayer();

            SetStyle(
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.UserPaint |
            ControlStyles.DoubleBuffer,
            true);

            Settings.onHideFrom += hideForm;

            btn_leftClicker.PerformClick();
        }

        private void btn_rightClicker_Click(object sender, EventArgs e) => addUserControl(panel_module, Page.RightClicker);

        private void btn_leftClicker_Click(object sender, EventArgs e) => addUserControl(panel_module, Page.LeftClicker);

        private void btn_settings_Click(object sender, EventArgs e) => addUserControl(panel_module, Page.Settings);

        private void hideForm(object obj)
        {
            if (appHide)
                Hide();
            else
                Show();
        }
    }
}

