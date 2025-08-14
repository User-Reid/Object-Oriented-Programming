var rectangle1 = new Rectangle(5,2);
var rectangle2 = new Rectangle(4, 9);


System.Console.WriteLine($"{rectangle1.Width}");
System.Console.WriteLine($"{rectangle1.Height}");
System.Console.WriteLine($"{rectangle2.Width}");
System.Console.WriteLine($"{rectangle2.Height}");

rectangle1.Width = -15;

Console.ReadKey();

class Rectangle
{
  const int NumberOfSides = 4;
  public readonly int Width;
  public readonly int Height;

  public Rectangle(int width, int height)
  {
    Width = GetLengthOrDefault(width, nameof(Width));
    Height = GetLengthOrDefault(height, nameof(Height));
  }

  private int GetLengthOrDefault(int length, string name)
  {
    const int defaultValueIfNonPositive = 1;
    if (length <= 0)
    {
      System.Console.WriteLine($"{name} must be a positive number.");
      return defaultValueIfNonPositive;
    }
    return length;
  }

  public int CalculatePermimeter(Rectangle rectangle) => 2 * rectangle.Width + 2 * rectangle.Height;
  public int CalculateArea(Rectangle rectangle) => rectangle.Width * rectangle.Height;
}

