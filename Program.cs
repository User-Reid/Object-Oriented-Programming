var rectangle1 = new Rectangle(5,2);
var rectangle2 = new Rectangle(4, 9);
var calculator = new ShapesMeasurementsCalculator();

System.Console.WriteLine($"{rectangle1.Width}");
System.Console.WriteLine($"{rectangle1.Height}");
System.Console.WriteLine($"{rectangle2.Width}");
System.Console.WriteLine($"{rectangle2.Height}");

System.Console.WriteLine($"the area of rectangle 1 is: {calculator.CalculateArea(rectangle1)}");
System.Console.WriteLine($"the area of rectangle 2 is: {calculator.CalculateArea(rectangle2)}");
System.Console.WriteLine($"the area of rectangle 1 is: {calculator.CalculatePermimeter(rectangle1)}");
System.Console.WriteLine($"the area of rectangle 2 is: {calculator.CalculatePermimeter(rectangle2)}");

Console.ReadKey();

class Rectangle
{
  public int Width;
  public int Height;

  public Rectangle(int width, int height)
  {
    Width = width;
    Height = height;
  }

}
class ShapesMeasurementsCalculator
  {
    public int CalculatePermimeter(Rectangle rectangle)
    {
      return 2 * rectangle.Width + 2 * rectangle.Height;
    }

    public int CalculateArea(Rectangle rectangle)
    {
      return rectangle.Width * rectangle.Height;
    }
  }