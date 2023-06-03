using AppConsola;

Console.WriteLine("Digite el tipo de figura geometrica a calcular el area");
Console.WriteLine("1 -> Circulo");
Console.WriteLine("2 -> Cuadrado");
Console.WriteLine("3 -> Triangulo");

int tipo = 0;

tipo = int.Parse(Console.ReadLine());

FiguraGeometrica figura;

switch (tipo)
{
    case 1: {
        Console.WriteLine("Digite el radio del circulo");
        float radio = float.Parse(Console.ReadLine());
        figura = new Circulo(radio);
        MostrarArea(figura);
        break;
    }
    case 2: {
        Console.WriteLine("digite el lado del cuadrado");
        float lado =  float.Parse(Console.ReadLine());
        figura = new Cuadrado(lado);
        MostrarArea(figura);
        break;
    }
    case 3:{
        Console.WriteLine("digite la base del triangulo");
        float _base = float.Parse(Console.ReadLine());
        Console.WriteLine("digite la altura del triangulo");
        float altura = float.Parse(Console.ReadLine());
        figura = new Triangulo(_base, altura);
        MostrarArea(figura);
        break;
    }
}

void MostrarArea(FiguraGeometrica figura){
    figura.CalcularArea();
    Console.WriteLine($"El area es {figura.Area}");
}

Console.ReadKey();