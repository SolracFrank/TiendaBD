using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DataAccess;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorProducto
    {
        Base _base;
        EntidadProducto producto;
        public ManejadorProducto()
        {
            _base = new Base("localhost","root","","Tienda",3306);
            
        }

        public void IngresarDatos(EntidadProducto producto)
        {
            
             _base.Consultar(string.Format("INSERT INTO producto VALUES(null,'{0}',{1},'{2}');", producto._Nombre, producto._Precio,
                producto._Descripcion));
        }
        public string getID(string dato)
        {
            return _base.ConsultaRetorno(string.Format("SELECT idProducto FROM producto WHERE Nombre = '{0}'",dato));
        }

        public string BorrarDatos(EntidadProducto producto)
        {
            return _base.ConsultaRetorno(string.Format("p_BorrarProducto ({0});", producto._idProducto));
        }

        public void ActualizarDatos(EntidadProducto producto)
        {
            _base.Consultar(string.Format("	UPDATE producto SET Nombre = '{0}', Precio = {1}, Descripcion = '{2}' WHERE idProducto = {3}", producto._Nombre,
                producto._Precio, producto._Descripcion, producto._idProducto));
              
        }
        public void Mostrar(DataGridView tabla, string dato)
        {
           tabla.DataSource = _base.Mostrar("producto",string.Format("SELECT * FROM producto WHERE Nombre like '%{0}%'",dato)).Tables["producto"];
            tabla.AutoResizeColumns();

        }


    }
}
