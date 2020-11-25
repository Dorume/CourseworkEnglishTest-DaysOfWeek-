using Lets__study_.Styles.RichTB;
using System.Drawing;
using System.Windows.Forms;

namespace Lets__study_.Styles
{
    class RichTBEnglishStyle : IRichTextBoxStyle
    {
        public RichTextBox GetStyle(int start, int end)
        {
            return new RichTextBox()
            {
                SelectionStart = start,
                SelectionLength = end,
                SelectionAlignment = HorizontalAlignment.Center,
                SelectionColor = Color.Chocolate,
                SelectionFont = new Font("Maiandra GD", 12)
            };
        }
        public RichTextBox GetStyle(int end)
        {
            return GetStyle(0, end);
        }

    }
}
