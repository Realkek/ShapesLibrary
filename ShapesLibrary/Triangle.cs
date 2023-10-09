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
        ValidateSides(_sideA, _sideB, _sideC);
        double semiperimeter = (_sideA + _sideB + _sideC) / QuadraticFactor;
        return Math.Sqrt(semiperimeter * (semiperimeter - _sideA) * (semiperimeter - _sideB) * (semiperimeter - _sideC));
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

    private static void ValidateSides(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            throw new ArgumentException("Стороны не могут ранять 0 или быть меньше");

        if (a + b <= c || a + c <= b || b + c <= a)
        {
            throw new ArgumentException("Стороны не образуют треугольник");
        }
    }
}