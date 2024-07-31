using NUnit.Framework;
using Figure;

namespace Figure.Tests
{
    [TestFixture]
    public class FigureTests
    {
        [Test]
        public void TestCircleArea()
        {
            Circle circle = new(2);
            Assert.That(Math.PI * 4, Is.EqualTo(circle.CalculateArea()));
        }

        [Test]
        public void TestTriangleArea()
        {
            Triangle triangle = new(3, 4, 5);
            Assert.That(6, Is.EqualTo(triangle.CalculateArea()));
        }


        [Test]
        public void TestIsRightTriangle()
        {
            Triangle rightTriangle = new(3, 4, 5);
            Assert.That(true, Is.EqualTo(rightTriangle.IsRightTriangle()));

            Triangle unRightTriangle = new(2, 2, 3);
            Assert.That(false, Is.EqualTo(unRightTriangle.IsRightTriangle()));
        }

        [OneTimeTearDown]
        public void AllTestsCompleted()
        {
            Assert.Pass("[Test] Все тесты выполнены успешно!");
        }
    }
}