namespace Clases
{
    public class Venta
    {
        public Venta(string nombre, DateTime dateTime)
        {
            Nombre = nombre;
            DateTime = dateTime;
        }
        
        public Venta(int id, string nombre, DateTime dateTime)
            :this (nombre, dateTime)
        {
            Id = id;
            Nombre = nombre;
            DateTime = dateTime;
        }


        public int Id { get; set; }

        public string Nombre { get; set; }

        public DateTime DateTime { get; set; }
    }
}