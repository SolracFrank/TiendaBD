namespace Entidades
{
    public class EntidadProducto
    {
        public EntidadProducto(int idProducto, string nombre, double precio, string descripcion)
        {
            _idProducto = idProducto;
            _Nombre = nombre;
            _Precio = precio;
            _Descripcion = descripcion;
        }

        public int _idProducto { get; set; }
        public string _Nombre { get; set; }
        public double _Precio { get; set; }
        public string _Descripcion { get; set; }
    }
}
