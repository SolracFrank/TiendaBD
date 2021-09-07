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
        public static bool edit = false;
        ManejadorProducto producto;
        EntidadProducto _prod;
        public frmPrincipal()
        {
            _prod = new EntidadProducto();
            producto = new ManejadorProducto();
            InitializeComponent();
        }

        void Cargar()
        {
            producto.Mostrar(dtgDatos, txtBuscar.Text);
        }

        void Limpiar()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
        }
        void editar()
        {
            


            _prod._idProducto = int.Parse(producto.getID(txtNombre.Text));
            _prod._Nombre = txtNombre.Text;
            _prod._Precio = double.Parse(txtPrecio.Text);
            _prod._Descripcion = txtDescripcion.Text;

            producto.ActualizarDatos(_prod);

            
        }
        void add()
        {
            _prod._idProducto = 0;
            _prod._Nombre = txtNombre.Text;
            _prod._Precio = double.Parse(txtPrecio.Text);
            _prod._Descripcion = txtDescripcion.Text;

            producto.IngresarDatos(_prod);
        
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Cargar();
            btnUpdate.Enabled = false;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (edit == false)
            {
                add();
            }
            else
            {
                
            }
            Limpiar();
        }

        private void dtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            txtNombre.Text = dtgDatos.CurrentRow.Cells["Nombre"].Value.ToString();
            txtDescripcion.Text = dtgDatos.CurrentRow.Cells["Descripcion"].Value.ToString();
            txtPrecio.Text = dtgDatos.CurrentRow.Cells["Precio"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            editar();
            btnUpdate.Enabled = false;
        }
    }
}
