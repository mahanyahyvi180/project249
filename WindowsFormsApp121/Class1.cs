using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp121
{
    public class Ntext : System.Windows.Forms.TextBox
    {

        protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (int)(e.KeyChar) != 8)
            {
                e.Handled = true;
            }
        }
    }
}
