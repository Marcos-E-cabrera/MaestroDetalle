namespace Clases
{
    public class Concepto
    {
        public Concepto(int cantidad, string producto, decimal precioUnitario)
        {
            Cantidad = cantidad;
            Producto = producto;
            PrecioUnitario = precioUnitario;
        }

        public Concepto(int id, int cantidad, string producto, decimal precioUnitario)
           : this( cantidad,producto,precioUnitario)
        {
            Id = id;
            Cantidad = cantidad;
            Producto = producto;
            PrecioUnitario = precioUnitario;
        }

       

        public int Id { get; set; }
        public int Cantidad { get; set; }
        public string Producto { get; set; }
        public decimal PrecioUnitario { get; set; }
    }
}