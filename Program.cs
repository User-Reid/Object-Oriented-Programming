// var medicalAppointment = new MedicalAppointment("Brandon", 05 / 30 / 2923);
// var appointmentOneWeekFromNow = new MedicalAppointment("Margerett Smith");
// medicalAppointment.Reschedule(new DateTime(2023, 4, 4));

// Dog.Describe("Lucky", "german shepherd", 40);
var taco = new Dog("Lucky", "german shepherd", 40);
var banana = new Dog("Salad Dressing", "poodle", 2);
var apple = new Dog("Butthead", "dragon", 20);
taco.Describe();
apple.Describe();
banana.Describe();

Console.ReadKey();

class Dog
{
  string _name;
  string _breed;
  int _weight;

  public Dog(string name, string breed, int weight)
  {
    _name = name;
    _breed = breed;
    _weight = weight;
  }

  public Dog(string name, int weight, string breed = "mixed-breed")
  {
    _name = name;
    _breed = breed;
    _weight = weight;
  }

  private string DescribeSize()
  {
    string size;

    if (_weight <= 5)
    {
      return "tiny";
    }
    else if (_weight > 5 && _weight < 30)
    {
      return "medium";
    }
    return "large";
  }

  public void Describe()
  {

    string size = "Fatass";

    if (_weight <= 5)
    {
      size = "tiny";
    }
    else if (_weight > 5 && _weight < 30)
    {
      size = "medium";
    }
    else if (_weight >= 30)
    {
      size = "large";
    }
    System.Console.WriteLine($"This dog is named {_name}, it's a {_breed}, and it weighs {_weight} kilograms, so it's a {DescribeSize()} dog.");
  }
    }

// class MedicalAppointmentPrinter
// {
//   public void Print(MedicalAppointment medicalAppointment)
//   {
//     System.Console.WriteLine("Appointment will take place on " + medicalAppointment.GetDate());
//   }
// }

// class MedicalAppointment
// {
//   string _patientName;
//   DateTime _date;

//   public MedicalAppointment(string patientName, DateTime date)
//   {
//     _patientName = patientName;
//     _date = date;
//   }

//   public DateTime GetDate() => _date;

//   // public MedicalAppointment(string patientName) : this(patientName, 7)
//   // {
//   // }

//   public MedicalAppointment(string patientName, int daysFromNow = 7)
//   {
//     _patientName = patientName;
//     _date = DateTime.Now.AddDays(daysFromNow);
//   }

//   public void Reschedule(DateTime date)
//   {
//     _date = date;
//     var printer = new MedicalAppointmentPrinter();
//     printer.Print(this);
//   }


//   public void OverideMonthAndDay(int month, int day) => _date = new DateTime(_date.Year, month, day);


//   public void MoveByMonthsAndDays(int monthsToAdd, int daysToAdd)
//   {
//     _date = new DateTime(_date.Year, _date.Month + monthsToAdd, _date.Day + daysToAdd);
//   }
// }

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