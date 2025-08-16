// var rectangle1 = new Rectangle(5,2);
// var rectangle2 = new Rectangle(4, 9);


// System.Console.WriteLine($"{rectangle1.Width}");
// System.Console.WriteLine($"{rectangle1.Height}");
// System.Console.WriteLine($"{rectangle2.Width}");
// System.Console.WriteLine($"{rectangle2.Height}");

// Console.ReadKey();

// class Rectangle
// {
//   public Rectangle(int width, int height)
//   {
//     Width = GetLengthOrDefault(width, nameof(Width));
//     _height = GetLengthOrDefault(height, nameof(Height));
//   }

//   private int _height;
//   public int Width { get; private set; }
//   public int Height
//   {
//     get { return _height; }
//     set
//     {
//       if (value > 0)
//       {
//         _height = value;
//       }
//     }
//   }

//   private int GetLengthOrDefault(int length, string name)
//   {
//     const int defaultValueIfNonPositive = 1;
//     if (length <= 0)
//     {
//       System.Console.WriteLine($"{name} must be a positive number.");
//       return defaultValueIfNonPositive;
//     }
//     return length;
//   }

//   public int CalculatePermimeter(Rectangle rectangle) => 2 * rectangle.Width + 2 * rectangle.Height;
//   public int CalculateArea(Rectangle rectangle) => rectangle.Width * rectangle.Height;
//   public string Description => $"A rectangle with width {Width} and height of {Height}";
// }

var taco = new DailyAccountState(2000, -200);
System.Console.WriteLine(taco.Report); 

Console.ReadKey();

class DailyAccountState
{
  public int InitialState { get; }

  public int SumOfOperations { get; }

  public DailyAccountState(
      int initialState,
      int sumOfOperations)
  {
    InitialState = initialState;
    SumOfOperations = sumOfOperations;
  }

  public int EndOfDayState => InitialState + SumOfOperations;
  public string Report => $"Day: {DateTime.Today.Day}, month: {DateTime.Today.Month}, year: {DateTime.Today.Year}, initial state: {InitialState}, end of day state: {EndOfDayState}";
}