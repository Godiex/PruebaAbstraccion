namespace AppConsola;

public class Cuadrado : FiguraGeometrica
{
    public float Lado { get; set; }

    public Cuadrado(float lado) : base()
    {
        Lado = lado;
    }

    public override void CalcularArea()
    {
        Area = Lado * Lado;
    }
}
