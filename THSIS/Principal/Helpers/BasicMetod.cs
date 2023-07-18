using CEN.Entidad;
using CLN;
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

        public static void cargarComboBox(ComboBox cmb, int PrefijoConcepto, String ValueMember, String DisplayMember)
        {
            List<ent_Concepto> lista;
            cln_Concepto cln = new cln_Concepto();
            lista = cln.listarConcepto(PrefijoConcepto);
            cmb.DataSource = lista;
            cmb.ValueMember = "conc_Descripcion";
            cmb.DisplayMember = "conc_Descripcion";
        }
    }
}
