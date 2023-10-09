using ShapesLibrary;

namespace ShapesTests;

public class TriangleTests
{
    [Theory]
    [InlineData(3, 4, 5, 6)]
    [InlineData(5, 12, 13, 30)]
    [InlineData(0, 0, 0, 0)]
    public void TriangleAreaTest(double a, double b, double c, double expectedArea)
    {
        Triangle triangle = new Triangle(a, b, c);
        Assert.Equal(expectedArea, triangle.GetArea(), 2);
    }

    [Theory]
    [InlineData(1, 1, 10)]
    [InlineData(10, 1, 1)]
    [InlineData(10, 20, 1)]
    public void InvalidSidesThrowException(double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }

    [Theory]
    [InlineData(3, 4, 5)]
    [InlineData(5, 12, 13)]
    [InlineData(8, 6, 10)]
    public void IsRightTriangleTest(double a, double b, double c)
    {
        Triangle triangle = new Triangle(a, b, c);
        Assert.True(triangle.IsRightAngled());
    }

    [Theory]
    [InlineData(3, 4, 6)]
    [InlineData(5, 12, 14)]
    public void IsNotRightTriangleTest(double a, double b, double c)
    {
        Triangle triangle = new Triangle(a, b, c);
        Assert.False(triangle.IsRightAngled());
    }

    [Fact]
    public void NegativeSidesThrowException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, 2, 2));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, -2, 2));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 2, -2));
    }

    [Fact]
    public void ZeroSidesThrowException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(0, 0, 0));
    }
}