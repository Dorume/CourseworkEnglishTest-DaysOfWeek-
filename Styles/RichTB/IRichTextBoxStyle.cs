using System.Windows.Forms;
namespace Lets__study_.Styles.RichTB
{
    interface IRichTextBoxStyle
    {
        RichTextBox GetStyle(int start, int end);
        RichTextBox GetStyle(int end);
    }
}
