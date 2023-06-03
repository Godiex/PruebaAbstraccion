namespace AppConsola;

public class Triangulo : FiguraGeometrica
{
    public float Base { get; set; }
    public float Altura { get; set; }

    public Triangulo(float _base, float altura) : base()
    {
        Base = _base;
        Altura = altura;
    }

    public override void CalcularArea()
    {
        Area = (Base * Altura) / 2;
    }
}
