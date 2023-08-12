using AppConsola.ModeloClases;

namespace AppConsola;

public class DetalleVenta
{
    public Libro Libro { get; set; }
    public int Cantidad { get; set; }
    public decimal Total { get; set; }
    public DetalleVenta(Libro libro, int cantidad)
    {
        Libro = libro;
        Cantidad = cantidad;
        Total = CalcularTotal(Cantidad);
    }

    public decimal CalcularTotal(int Cantidad){
        return Libro.PrecioUnitario * Cantidad;         
    }
    
}
