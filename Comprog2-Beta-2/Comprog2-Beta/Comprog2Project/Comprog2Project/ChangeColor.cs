using System.Windows.Forms;
using System.Drawing;

namespace Comprog2Project
{
    public class ChangeColor
    {

        public static void BackColor(Control control, Color color) => control.BackColor = color;
        public static void ForeColor(Control control, Color color) => control.ForeColor = color;

    }
}
