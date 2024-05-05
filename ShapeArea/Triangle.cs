namespace ShapeArea 
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : Shape
    {
        #region Fields

        private double side1;
        private double side2;
        private double side3;

        private double perimeter;

        #endregion Fields

        #region Constructor

        public Triangle(double side1, double side2, double side3) 
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        #endregion Constructor

        #region Methods

        /// <summary>
        /// Возвращает радиус треугольника по теореме Герона
        /// </summary>
        public override double Area()
        {
            perimeter = (side1 + side2 + side3) / 2;
            double area = Math.Sqrt(perimeter * (perimeter - side1) * (perimeter - side2) * (perimeter - side3));
            return area;
        }

        /// <summary>
        /// Является ли триугольник прямоугольным?
        /// </summary>
        public bool IsRightTriangle()
        {
            // если квадрат одной стороны рабен сумме квадратов двух других сторон, то треугольник прямоугольный

            if( side1 * side1 == side2 * side2 + side3 * side3)
                return true;
            
            if (side2 * side2 == side1 * side1 + side3 * side3)
                return true;

            if (side3 * side3 == side2 * side2 + side1 * side1)
                return true;

            return false;
        }
        #endregion Methods
    }
}
