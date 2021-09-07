using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores;
using Entidades;

namespace Presentaciones
{
    public partial class frmPrincipal : Form
    {

        ManejadorProducto producto;
        public frmPrincipal()
        {
            producto = new ManejadorProducto();
            InitializeComponent();
        }

        void Cargar()
        {
            producto.Mostrar(dtgDatos, txtBuscar.Text);
        }
        

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
