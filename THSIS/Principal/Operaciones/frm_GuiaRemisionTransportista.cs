﻿using Principal.Helpers;
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
    public partial class frm_GuiaRemisionTransportista : Form
    {



        #region "Constructor"
        public frm_GuiaRemisionTransportista()
        {
            InitializeComponent();
        }
        #endregion
        #region "Eventos"
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            BasicMetod.CerrarPestaniaPrincipal("Guia Remisión");
        }
        #endregion
        #region "Métodos"

        #endregion
    }
}
