namespace ShapeArea
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : Shape
    {

        #region Fields

        /// <summary>
        /// Радиус
        /// </summary>
        private double radius;

        #endregion Fields

        #region Constructor

        public Circle(double radius)
        {
            this.radius = radius;
        }

        #endregion Constructor

        #region Methods

        /// <summary>
        /// Возвращает радиус круга 
        /// </summary>
        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        #endregion Methods
    }
}
