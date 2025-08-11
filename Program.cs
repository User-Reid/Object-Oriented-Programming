var rectangle1 = new Rectangle();

System.Console.WriteLine($"{rectangle1.width}");
System.Console.WriteLine($"{rectangle1.height}");

Console.ReadKey();

class Rectangle
{
  public int width;
  public int height;

  void DummyMethod()
  {
    System.Console.WriteLine($"{width + height}");
  }
}