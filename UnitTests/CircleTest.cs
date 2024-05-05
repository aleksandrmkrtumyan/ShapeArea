using ShapeArea;
using Xunit;

namespace UnitTests
{
    public class CircleTest
    {
        #region Consts

        private const double circleRightArea = 3.1415926535897931;

        private const double circleWrongArea = 6.28;

        #endregion Consts

        #region Fields

        private double radius = 1;
        private Shape shape;
        #endregion Fields

        #region Constructor

        public CircleTest()
        {
            shape = new Circle(radius);
        }

        #endregion Constructor

        #region Methods

        [Fact]  
        public void AreaGoodTesting()
        {
            var area = shape.Area();
            Assert.Equal(circleRightArea, area);
        }

        [Fact]
        public void AreaWrongTesting()
        {
            var area = shape.Area();
            Assert.NotEqual(circleWrongArea, area);
        }

        #endregion Methods
    }
}
