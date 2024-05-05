using ShapeArea;

Shape shape = new Circle(12);
var area = shape.Area();

Console.WriteLine($"Circle area = {area}");


shape = new Triangle(4, 3, 5);
area = shape.Area();
Console.WriteLine($"Triangle area = {area}");

var isRightTriangle = ((Triangle)shape).IsRightTriangle();

if (isRightTriangle)
    Console.WriteLine("is right triangle");
else
    Console.WriteLine("is not right triangle");

Console.ReadLine();