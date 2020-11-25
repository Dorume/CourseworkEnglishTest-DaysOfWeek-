using Lets__study_.Styles.RichTB;
using System.Drawing;
using System.Windows.Forms;

namespace Lets__study_.Styles
{
    class RichTBEnglishStyle : IRichTextBoxStyle
    {
        public void GetStyle(RichTextBox textBox)
        {
            textBox.ForeColor = Color.Chocolate;
            textBox.Font = new Font("Maiandra GD", 16);
        }

    }
}
