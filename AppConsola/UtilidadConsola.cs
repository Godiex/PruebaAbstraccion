namespace AppConsola;

public static class UtilidadConsola
{
    public static string Leer(string texto){
        Console.WriteLine(texto);
        return Console.ReadLine();
    }

    public static int Leer(int textoNumero){
        Console.WriteLine(textoNumero);
        return int.Parse(Console.ReadLine());
    }
}
