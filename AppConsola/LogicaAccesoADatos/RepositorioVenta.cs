using AppConsola.ModeloClases;
namespace AppConsola.LogicaAccesoADatos;

public class RepositorioVenta
{
    public  List<Venta> Ventas { get; set; }
    public RepositorioVenta()
    {
        Ventas = new List<Venta>();
    }

    public void AgregarVentas(Venta venta){
        Ventas.Add(venta);
    }



}
