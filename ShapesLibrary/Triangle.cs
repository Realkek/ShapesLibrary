namespace ShapesLibrary;

public class Triangle : IShape
{
    private const int QuadraticFactor = 2;
    private double _sideA;
    private double _sideB;
    private double _sideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }

    /// <summary>
    /// Вычисление площади треугольника по формуле Герона
    /// </summary>
    public double GetArea()
    {
        double p = (_sideA + _sideB + _sideC) / QuadraticFactor;
        return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
    }

    /// <summary>
    /// Проверка прямоугольности по теореме Пифагора 
    /// </summary>
    public bool IsRightAngled()
    {
        double eps = 1e-6;

        return Math.Abs(Math.Pow(_sideA, QuadraticFactor) + Math.Pow(_sideB, QuadraticFactor) -
                        Math.Pow(_sideC, QuadraticFactor)) < eps ||
               Math.Abs(Math.Pow(_sideB, QuadraticFactor) + Math.Pow(_sideC, QuadraticFactor) -
                        Math.Pow(_sideA, QuadraticFactor)) < eps ||
               Math.Abs(Math.Pow(_sideC, QuadraticFactor) + Math.Pow(_sideA, QuadraticFactor) -
                        Math.Pow(_sideB, QuadraticFactor)) < eps;
    }
}