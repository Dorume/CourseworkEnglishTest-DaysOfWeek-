using Lets__study_.Styles.ButtonsS.Interface;
using System.Drawing;
using System.Windows.Forms;

namespace Lets__study_.Styles.ButtonsS
{
    class ButtonEglishStyle : IButtonStyle
    {
        public void GetStyle(Button button)
        {
            button.BackColor = Color.Wheat;
        }
    }
}
