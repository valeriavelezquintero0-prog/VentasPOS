using System.Globalization;

namespace VentasPOS
{
    // Clase (objeto) que representa un producto
    public class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public Producto(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        // Lo que se ve en el ComboBox
        public override string ToString()
        {
            return Nombre + " - $" + Precio.ToString("N0", new CultureInfo("es-CO"));
        }
    }
}