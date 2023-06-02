using Infragistics.Win.UltraWinEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.Operaciones
{
    public partial class frm_Vehiculo : Form
    {
        private UltraColorPicker cpk_Color;
        public frm_Vehiculo()
        {
            InitializeComponent();
            cpk_Color = new UltraColorPicker();
            cpk_Color.Color = Color.Aquamarine;
        }
    }
}
