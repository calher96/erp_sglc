using CEN.Entidad;
using CLN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

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
            cmb.ValueMember = ValueMember;
            cmb.DisplayMember = DisplayMember;
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

        public static void MostrarCarga(PictureBox pictureBoxCarga)
        {
            pictureBoxCarga.Visible = true;
        }

        public static void OcultarCarga(PictureBox pictureBoxCarga)
        {
            pictureBoxCarga.Visible = false;
        }

        public static void CerrarPestaniaPrincipal(String tabPage)
        {
            TabPage tp = mdi_Principal.tbc_Principal.TabPages[tabPage];
            mdi_Principal.tbc_Principal.TabPages.Remove(tp);
        }

        public static void abrirFormHijo(Object form, String titulo)
        {
            try
            {
                TabPage tp = mdi_Principal.tbc_Principal.TabPages[titulo];
                if (tp == null)
                {
                    TabPage tabpage = new TabPage();
                    Form fh = form as Form;
                    fh.AutoScroll = true;
                    fh.TopLevel = false;
                    fh.Dock = DockStyle.Fill;
                    fh.Parent = tabpage;
                    //childFormNumber++;
                    tabpage.Name = titulo;
                    tabpage.Controls.Add(fh);
                    tabpage.Text = titulo;
                    tabpage.BackColor = Color.Blue;
                    tabpage.AutoScroll = true;
                    mdi_Principal.tbc_Principal.TabPages.Add(tabpage);
                    mdi_Principal.tbc_Principal.SelectedIndex = mdi_Principal.tbc_Principal.Controls.Count - 1;
                    mdi_Principal.tbc_Principal.Show();
                    tabpage.Show();
                    fh.Show();
                }
                else
                {
                    mdi_Principal.tbc_Principal.SelectedTab = tp;
                }
            }
            catch
            {
                throw;
            }
        }

        public static void ExportToExcel(DataGridView dataGridView, String nombre)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = nombre;
            saveFileDialog.Filter = "Archivos de Excel|*.xlsx";
            saveFileDialog.Title = "Guardar archivo de Excel";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Crear una nueva instancia de Excel y agregar un nuevo libro
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true;
                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];

                // Exportar los encabezados de las columnas
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;
                }

                // Exportar los datos del DataGridView
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView[j, i].Value;
                    }
                }

                // Guardar el archivo en la ubicación seleccionada por el usuario
                string filePath = saveFileDialog.FileName;
                Excel.Range usedRange = worksheet.UsedRange;
                usedRange.Columns.AutoFit();
                usedRange.Rows.AutoFit();

                workbook.SaveAs(filePath);

                // Cerrar Excel
                excelApp.Quit();

                
            }
        }
    }
}
