var taco = new Order("Banana's", new DateTime(2020, 8, 14));
System.Console.WriteLine($"{taco.Date}");
System.Console.WriteLine($"{taco.Item}");

Console.ReadLine();

class Order
    {
  private DateTime _date;
  public string Item { get; }
  public DateTime Date { get { return _date; } set
    {
      if (value.Year == DateTime.Today.Year)
      {
         _date = value;
    }
  } }
        public Order(string item, DateTime date)
  {
    Item = item;
    Date = date;
  }
    }
// var rectangle1 = new Rectangle(5,2);
// var rectangle2 = new Rectangle(4, 9);


// System.Console.WriteLine($"{rectangle1.Width}");
// System.Console.WriteLine($"{rectangle1.GetHeight()}");
// System.Console.WriteLine($"{rectangle2.Width}");
// System.Console.WriteLine($"{rectangle2.GetHeight()}");

// Console.ReadKey();

// class Rectangle
// {
//   public Rectangle(int width, int height)
//   {
//     Width = GetLengthOrDefault(width, nameof(Width));
//     _height = GetLengthOrDefault(height, nameof(_height));
//   }

//   public int Width { get; private set; }
//   private int _height;

//   public int GetHeight() => _height;

//   public void SetHeight(int value)
//   {
//     if (value > 0)
//     {
//       _height = value;
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

//   public int CalculatePermimeter(Rectangle rectangle) => 2 * rectangle._width + 2 * rectangle._height;
//   public int CalculateArea(Rectangle rectangle) => rectangle._width * rectangle._height;
// }

