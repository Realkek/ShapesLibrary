
using ShapesLibrary;

namespace ShapesTests;

public class CircleTests
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 3.14)]
    [InlineData(10, 314)]  
    [InlineData(5, 78.5)]  
    public void CheckCircleAreaCalculation(
        double radius, double expectedArea)
    {
        Circle circle = new Circle(radius);
        Assert.Equal(expectedArea, circle.GetArea(), 2); 
    }
  
    [Fact]
    public void NegativeRadiusThrowsException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            var circle = new Circle(-1);
        });
    }
    [Fact]
    public void ZeroRadiusCreatesValidCircle()
    {
        var circle = new Circle(0);
        Assert.Equal(0, circle.Radius);
        Assert.Equal(0, circle.GetArea()); 
    }
}