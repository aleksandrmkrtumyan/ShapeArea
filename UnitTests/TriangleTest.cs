using ShapeArea;
using Xunit;

namespace UnitTests
{
    public class TriangleTest
    {
        #region Consts

        private const double testTriangleArea = 6;

        private const double trinagleWrongArea = 5;

        #endregion Consts

        #region Fields

        Shape shape = new Triangle(3, 4, 5);

        #endregion Fields

        #region Methods

        /// <summary>
        /// Проверка правильного результата
        /// </summary>
        [Fact]
        public void AreaGoodTesting()
        {
            var area = shape.Area();
            Assert.Equal(testTriangleArea, area);            
        }

        /// <summary>
        /// Проверка не правильного результата
        /// </summary>
        [Fact]
        public void AreaWrongTesting()
        {
            var area = shape.Area();
            Assert.NotEqual(trinagleWrongArea, area);
        }

        /// <summary>
        /// Проверка на то, что триугольник прямоугольный
        /// </summary>
        [Fact]
        public void RightAngularTest()
        {
            var isRight = ((Triangle)shape).IsRightTriangle();

            Assert.True(isRight);
        }

        #endregion Methods

    }
}
