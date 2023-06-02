using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Helpers
{
    public class BasicMetod
    {
        public static Color obtenerColorComboBox(Object combo)
        {
            ComboBox cbo = (ComboBox)combo;
            Color color = Color.White;
            if (cbo.SelectedIndex >= 0)
                color = (Color)cbo.SelectedValue;
            return color;
        }
    }
}
