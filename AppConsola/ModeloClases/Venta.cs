namespace AppConsola.ModeloClases;

public class Venta
{
    public List <DetalleVenta> LibrosComprados { get; set;}
    public decimal Total { get; set;}

    public Venta()
    {
        LibrosComprados = new List<DetalleVenta>();
    }

    public void CalcularTotal(){
        foreach (var item in LibrosComprados)
        {
            Total += item.Total;
        }
    }

}
