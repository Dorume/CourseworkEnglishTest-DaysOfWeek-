using Lets__study_.Styles.Panels.Interface;
using System.Drawing;
using System.Windows.Forms;

namespace Lets__study_.Styles.Panels
{
    class PanelsEnglishStyle : IPanelStyle
    {
        public void GetStyle(Panel panel)
        {
            panel.BackColor = Color.PapayaWhip;
        }
    }
}
