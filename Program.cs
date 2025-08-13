

Console.ReadKey();

class MedicalAppointment
{
  string _patientName;
  DateTime _date;

  public MedicalAppointment(string patientName, DateTime date)
  {
    _patientName = patientName;
    _date = date;
  }

  public MedicalAppointment(string patientName) : this(patientName, 7) {
  }

  public MedicalAppointment(string patientName, int daysFromNow) {
    _patientName = patientName;
    _date = DateTime.Now.AddDays(daysFromNow);
  }

  public void Reschedule(DateTime date)
  {
    _date = date;
  }

  public void OverideMonthAndDay(int month, int day)
  {
    _date = new DateTime(_date.Year, month, day);
  }

  public void MoveByMonthsAndDays(int monthsToAdd, int daysToAdd)
  {
    _date = new DateTime(_date.Year, date.Month + monthsToAdd, _date.Day + daysToAdd)
  }
}

// var rectangle1 = new Rectangle(5,2);
// var rectangle2 = new Rectangle(4, 9);
// var calculator = new ShapesMeasurementsCalculator();

// System.Console.WriteLine($"{rectangle1.Width}");
// System.Console.WriteLine($"{rectangle1.Height}");
// System.Console.WriteLine($"{rectangle2.Width}");
// System.Console.WriteLine($"{rectangle2.Height}");

// System.Console.WriteLine($"the area of rectangle 1 is: {calculator.CalculateArea(rectangle1)}");
// System.Console.WriteLine($"the area of rectangle 2 is: {calculator.CalculateArea(rectangle2)}");
// System.Console.WriteLine($"the area of rectangle 1 is: {calculator.CalculatePermimeter(rectangle1)}");
// System.Console.WriteLine($"the area of rectangle 2 is: {calculator.CalculatePermimeter(rectangle2)}");

// Console.ReadKey();

// class Rectangle
// {
//   public int Width;
//   public int Height;

//   public Rectangle(int width, int height)
//   {
//     Width = width;
//     Height = height;
//   }

// }
// class ShapesMeasurementsCalculator
//   {
//     public int CalculatePermimeter(Rectangle rectangle)
//     {
//       return 2 * rectangle.Width + 2 * rectangle.Height;
//     }

//     public int CalculateArea(Rectangle rectangle)
//     {
//       return rectangle.Width * rectangle.Height;
//     }
//   }