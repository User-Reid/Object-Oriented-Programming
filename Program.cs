// var rectangle1 = new Rectangle(5,2);
// var rectangle2 = new Rectangle(4, 9);

// System.Console.WriteLine(Rectangle.DescribeGenerally());
// System.Console.WriteLine($"{rectangle1.Width}");
// System.Console.WriteLine($"{rectangle1.Height}");
// System.Console.WriteLine($"{rectangle2.Width}");
// System.Console.WriteLine($"{rectangle2.Height}");


// System.Console.WriteLine($"1 + 2 is {Calculator.Add(1, 2)}");
// System.Console.WriteLine($"1 - 2 is {Calculator.Subtract(1, 2)}");
// System.Console.WriteLine($"1 * 2 is {Calculator.Multiply(1, 2)}");

// System.Console.WriteLine($"Count of Rectangle objects is {Rectangle.CountOfInstances}");

// Console.ReadKey();

// static class Calculator
// {
//     public static int Add(int a, int b) => a + b;
//     public static int Subtract(int a, int b) => a - b;
//     public static int Multiply(int a, int b) => a * b;

// }

// class Rectangle
// {

//   private static DateTime _firstUsed = DateTime.Now;
//   public static int CountOfInstances { get; private set; }
//   public Rectangle(int width, int height)
//   {
//     Width = GetLengthOrDefault(width, nameof(Width));
//     _height = GetLengthOrDefault(height, nameof(Height));
//     ++CountOfInstances;
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

//   public static string DescribeGenerally() => $"A plane figure with four straight sides and four right angles.";
// }

var names = new Names();
var path = names.BuildFilePath();
var stringsTextualRepository = new StringsTextualRepository();

if (File.Exists(path))
{
  Console.WriteLine("Names file already exists. Loading names.");
  var stringsFromFile = stringsTextualRepository.Read(path);
  names.AddNames(stringsFromFile);
}
else
{
  Console.WriteLine("Names file does not yet exist.");

  //let's imagine they are given by the user
  names.AddName("John");
  names.AddName("not a valid name");
  names.AddName("Claire");
  names.AddName("123 definitely not a valid name");

  Console.WriteLine("Saving names to the file.");
  stringsTextualRepository.Write(path, names.All);
}
Console.WriteLine(names.Format());

Console.ReadLine();

public class StringsTextualRepository
{
  private static readonly string Seperator = Environment.NewLine;
  public List<string> Read(string filePath)
  {
    var fileContents = File.ReadAllText(filePath);
    return fileContents.Split(Seperator).ToList();
  }

  public void Write(string filePath, List<string> strings) =>
      File.WriteAllText(filePath, string.Join(Seperator, strings));
}

public class NamesValidator
{
  public bool IsValid(string name)
  {
    return
        name.Length >= 2 &&
        name.Length < 25 &&
        char.IsUpper(name[0]) &&
        name.All(char.IsLetter);
  }
}

public class Names
{
  public List<string> All { get; } = new List<string>();
  private readonly NamesValidator _namesValidator = new NamesValidator();

  public void AddNames(List<string> stringsFromFile)
  {
    foreach (var name in stringsFromFile)
    {
      AddName(name);
    }
  }

  public void AddName(string name)
  {
    if (_namesValidator.IsValid(name))
    {
      All.Add(name);
    }
  }

  public string BuildFilePath()
  {
    //we could imagine this is much more complicated
    //for example that path is provided by the user and validated
    return "names.txt";
  }

  public string Format() =>
      string.Join(Environment.NewLine, All);
}
