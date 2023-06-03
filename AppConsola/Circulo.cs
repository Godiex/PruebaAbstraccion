namespace AppConsola;

public class Circulo : FiguraGeometrica
{
    public float Radio { get; set; }

    public Circulo(float radio) : base()
    {
        Radio = radio;
    }

    public override void CalcularArea()
    {
        Area = (float) (Math.PI * Math.Pow(Radio, 2));
    }
}
