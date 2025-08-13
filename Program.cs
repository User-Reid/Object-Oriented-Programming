var rectangle1 = new Rectangle(5,2);
var rectangle2 = new Rectangle(4,9);

System.Console.WriteLine($"{rectangle1.Width}");
System.Console.WriteLine($"{rectangle1.Height}");
System.Console.WriteLine($"{rectangle2.Width}");
System.Console.WriteLine($"{rectangle2.Height}");

System.Console.WriteLine($"the area of rectangle 1 is: {rectangle1.CalculateArea()}");
System.Console.WriteLine($"the area of rectangle 2 is: {rectangle2.CalculateArea()}");
System.Console.WriteLine($"the area of rectangle 1 is: {rectangle1.CalculatePermimeter()}");
System.Console.WriteLine($"the area of rectangle 2 is: {rectangle2.CalculatePermimeter()}");

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

  public int CalculateArea()
  {
    return Width * Height;
  }

  public int CalculatePermimeter() {
    return 2 * Width + 2 * Height;
  }
}