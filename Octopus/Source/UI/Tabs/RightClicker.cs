using System;
using System.Windows.Forms;
//---------------------------
using static Octopus.Minecraft;
using static Octopus.Keyboard;
using static Octopus.Cursored;
using static Octopus.Configs;
using static Octopus.Imports;
using static Octopus.Clicks;
//---------------------------

namespace Octopus
{
    public partial class RightClicker : UserControl
    {
        public RightClicker()
        {
            InitializeComponent();

            Custom(trackbar_average, label_average);

            Keyboard.KeyDown += Keyboard_KeyDown;
        }

        private void Keyboard_KeyDown(VKeys key)
        {
            Toggle(checkbox_toggle, key, toggleRight);
        }

        public void Custom(Guna.UI2.WinForms.Guna2ProgressBar progressBar, Guna.UI2.WinForms.Guna2Button label)
        {
            progressBar.MouseMove += (b, d) =>
            {
                if (MouseButtons == MouseButtons.Left)
                {
                    float absoluteMouse = (PointToClient(MousePosition).X - progressBar.Bounds.X);
                    float calcFactor = progressBar.Width / (float)progressBar.Maximum;
                    float relativeMouse = absoluteMouse / calcFactor;

                    progressBar.Value = Convert.ToInt32(relativeMouse);

                    if (progressBar.Value <= 10)
                        progressBar.Value = 10;

                    label.Text = $"{progressBar.Value / 10}";

                }
            };
        }

        private void checkbox_toggle_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_toggle.Checked)
                clicker.Start();
            else
                clicker.Stop();
        }

        private void checkbox_blatant_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_blatant.Checked)
                trackbar_average.Maximum = 1000;
            else
            {
                trackbar_average.Maximum = 200;
                if (trackbar_average.Value >= 200)
                {
                    trackbar_average.Value = 200;
                    label_average.Text = $"{trackbar_average.Value / 10}";
                }
            }
        }

        private void clicker_Tick(object sender, EventArgs e)
        {
            Connect(clicker, trackbar_average);

            if (MouseButtons == MouseButtons.Right)
            {
                //if (Config.whitelistedSlots[Config.currentSlot])
                //    return;
                if (checkbox_shiftdisable.Checked && GetAsyncKeyState(Keys.LShiftKey) != 0)
                    return;
                else if (checkbox_onlyingame.Checked && IsCursorVisible())
                    return;
                else if (checkbox_eatbow.Checked)
                    RightModified();
                else
                    Right();
            }
        }

        private void checkbox_hotkey_KeyDown(object sender, KeyEventArgs e)
        {
            if (checkbox_hotkey.Checked)
            {
                toggleRight = ConvertToBindable(e);
                label_hotkey.Text = $"Hotkey [{toggleRight}]";
                checkbox_hotkey.Checked = false;
            }
        }
    }
}
