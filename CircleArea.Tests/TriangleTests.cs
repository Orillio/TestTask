using System;
using Xunit;

namespace CircleArea.Tests
{
    public class FigureTests
    {
        [Fact]
        public void CalculateCircleAreaTest()
        {
            int radius = 3;

            // Arrange
            IFigure circle = new Circle(radius);

            // Act
            double area = circle.CalculateArea();

            // Assert
            Assert.Equal(area, Math.PI * Math.Pow(radius, 2));

        }
        [Fact]
        public void CalculateTriangleAreaTest()
        {
            int a = 3;
            int b = 4;
            int c = 5;

            // Arrange
            IFigure triangle = new Triangle(a, b, c);

            // Act
            double area = triangle.CalculateArea();

            // Assert
            Assert.Equal(area, 6.0);

        }
        [Fact]
        public void IsRightTriangleTest()
        {
            int a = 3;
            int b = 4;
            int c = 5;

            // Arrange
            Triangle triangle = new Triangle(a, b, c);

            // Act
            var result = triangle.IsRightTriangle();

            // Assert
            Assert.True(result);

        }
    }
}