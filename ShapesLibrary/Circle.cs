using ShapesLibrary.Interfaces;

namespace ShapesLibrary;

public class Circle : IShape
{
    public double Radius { get; private set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    /// <summary>
    /// Подсчёт площади круга по стандартной формуле 
    /// </summary>
    public double GetArea()
    {
        ValidateRadius();
        return Math.PI * Radius * Radius;
    }

    private void ValidateRadius()
    {
        if (Radius < 0)
            throw new ArgumentOutOfRangeException();
    }
}