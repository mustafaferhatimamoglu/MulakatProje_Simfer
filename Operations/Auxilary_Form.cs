using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulakatProje_Simfer.Operations
{
    internal class Auxilary_Form
    {
        internal static KeyPressEventArgs OnlyNumber(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
           //     && (e.KeyChar != '.')
           )
            {
                e.Handled = true;
            }
            return e;
        }
    }
}
