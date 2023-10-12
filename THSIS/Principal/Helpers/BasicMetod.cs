using CEN.Entidad;
using CLN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            cmb.ValueMember = "Descripcion";
            cmb.DisplayMember = "Descripcion";
        }

        public static void seleccionarItemComboBoxConcepto(ComboBox cmb, ent_Concepto Concepto)
        {
            for (int i = 0; i < cmb.Items.Count; i++)
            {
                ent_Concepto conceptoEnComboBox = cmb.Items[i] as ent_Concepto;

                if (conceptoEnComboBox.Correlativo == Concepto.Correlativo)
                {
                    cmb.SelectedIndex = i;
                }
            }
        }

        public static void seleccionarUbigeo(ComboBox cmb, String Ubigeo, string tipo)
        {
            switch(tipo)
            {
                case "DEPARTAMENTO":
                    for (int i = 0; i < cmb.Items.Count; i++)
                    {
                        ent_Ubigeo conceptoEnComboBox = cmb.Items[i] as ent_Ubigeo;

                        if (conceptoEnComboBox.Ubigeo == Ubigeo.Substring(0,2))
                        {
                            cmb.SelectedIndex = i;
                            break;
                        }
                    }
                    break;
                case "PROVINCIA":
                    for (int i = 0; i < cmb.Items.Count; i++)
                    {
                        ent_Ubigeo conceptoEnComboBox = cmb.Items[i] as ent_Ubigeo;

                        if (conceptoEnComboBox.Ubigeo == Ubigeo.Substring(0, 4))
                        {
                            cmb.SelectedIndex = i;
                            break;
                        }
                    }
                    break;
                case "DISTRITO":
                    for (int i = 0; i < cmb.Items.Count; i++)
                    {
                        ent_Ubigeo conceptoEnComboBox = cmb.Items[i] as ent_Ubigeo;

                        if (conceptoEnComboBox.Ubigeo == Ubigeo)
                        {
                            cmb.SelectedIndex = i;
                            break;
                        }
                    }
                    break;
            }
            
        }
    }
}
