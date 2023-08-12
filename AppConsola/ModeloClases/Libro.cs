namespace AppConsola.ModeloClases;
using System;

public class Libro
{
    public string Titulo { get; private set; } = string.Empty;
    public string ISBN { get; private set;} = string.Empty;
    public string Autor { get; private set; } = string.Empty;
    public decimal PrecioUnitario { get; private set; }
    public int Stock { get; private set; }

    public Libro(string titulo, string autor, decimal precioUnitario, int stock)
    {
        Titulo = titulo;
        Autor = autor;  
        PrecioUnitario = precioUnitario;
        Stock = stock;
        SetIsbn();
    }

    public void SetIsbn(){
        var randon = new Random();
        ISBN = Convert.ToString(randon.Next(111,999));

    }

}