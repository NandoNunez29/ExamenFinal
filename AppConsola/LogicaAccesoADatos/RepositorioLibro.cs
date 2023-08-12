using AppConsola.ModeloClases;

namespace AppConsola.LogicaAccesoADatos;

public class RepositorioLibro
{
    List<Libro> Libros { get; set; }

    public RepositorioLibro()
    {
        Libros = new List<Libro>();
    }

    public void AgregarLibro(Libro libro){
        Libros.Add(libro);
    }

    public void InicializarRepositorioLibro(){
        Libro libro = new Libro("Cien Años de soledad", "Gabriel Garcia Marquez", 150000, 12);
        AgregarLibro(libro);
        Libro libro1 = new Libro("El Coronel No tiene quien le escriba", "Gabriel Garcia Marquez", 80000, 10);
        AgregarLibro(libro1);
        Libro libro2 = new Libro("Padre Rico", "Robert Kiyo", 120000, 6);
        AgregarLibro(libro2);
        Libro libro3 = new Libro("Libertad", "Andrs goid", 41000, 2);
        AgregarLibro(libro3);
    }
}
