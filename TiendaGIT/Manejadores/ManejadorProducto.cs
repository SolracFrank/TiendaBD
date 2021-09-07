using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DataAccess;

namespace Manejadores
{
    public class ManejadorProducto
    {
        Base _base;
        public ManejadorProducto()
        {
            _base = new Base("localhost","root","","Tienda",3306);
        }




    }
}
