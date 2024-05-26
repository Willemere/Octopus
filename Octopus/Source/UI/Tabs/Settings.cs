using System.Windows.Forms;
//---------------------------
using static Octopus.Configs;
//---------------------------

namespace Octopus
{
    public partial class Settings : UserControl
    {
        public delegate void MethodHide(object obj);

        public static event MethodHide onHideFrom;

        public Settings()
        {
            InitializeComponent();
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
                if (appHide)
                    if (onHideFrom != null)
                        onHideFrom(this);
                    else
                    if (onHideFrom != null)
                        onHideFrom(this);
            }

        }
    }
}
