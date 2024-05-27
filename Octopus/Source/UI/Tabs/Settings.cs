using System;
using System.Windows.Forms;
//---------------------------
using static Octopus.Keyboard;
using static Octopus.Configs;
//---------------------------

namespace Octopus
{
    public partial class Settings : UserControl
    {
        public delegate void Method(object obj);

        public static event Method onHideFrom;

        public static event Method onTopMostForm;

        public Settings()
        {
            InitializeComponent();

            Keyboard.KeyDown += Keyboard_KeyDown;
        }

        private void Keyboard_KeyDown(VKeys key)
        {
            Toggle(checkbox_hide, key, toggleHide);
        }

        private void checkbox_hide_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkbox_hide.Checked)
            {
                appHide = true;
                if (appHide)
                    if (onHideFrom != null)
                        onHideFrom(this);
                else
                    if (onHideFrom != null)
                        onHideFrom(this);
            }
            else
            {
                appHide = false;
                if (!appHide)
                    if (onHideFrom != null)
                        onHideFrom(this);
                    else
                    if (onHideFrom != null)
                        onHideFrom(this);
            }

        }

        private void checkbox_hidehotkey_KeyDown(object sender, KeyEventArgs e)
        {
            if (checkbox_hidehotkey.Checked)
            {
                toggleHide = ConvertToBindable(e);
                label_hotkey.Text = $"Hotkey [{toggleHide}]";
                checkbox_hidehotkey.Checked = false;
            }
        }

        private void checkbox_topmost_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_topmost.Checked)
            {
                appTopMost = true;
                if (appTopMost)
                    if (onTopMostForm != null)
                        onTopMostForm(this);
                    else
                    if (onTopMostForm != null)
                        onTopMostForm(this);
            }
            else
            {
                appTopMost = false;
                if (!appTopMost)
                    if (onTopMostForm != null)
                        onTopMostForm(this);
                    else
                    if (onTopMostForm != null)
                        onTopMostForm(this);
            }
        }
    }
}
