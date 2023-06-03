namespace AppConsola;

public abstract class FiguraGeometrica
{
    public float Area { get; protected set; }
    public abstract void CalcularArea();
}
