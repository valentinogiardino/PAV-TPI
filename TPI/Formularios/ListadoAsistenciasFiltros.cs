﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPI.Formularios
{
    public partial class ListadoAsistenciasFiltros : Form
    {
        public ListadoAsistenciasFiltros()
        {
            InitializeComponent();
        }

        private void ListadoAsistenciasFiltros_Load(object sender, EventArgs e)
        {

            this.reporteAsistenciaFiltros.RefreshReport();
        }
    }
}
