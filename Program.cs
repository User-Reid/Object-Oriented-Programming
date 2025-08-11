

Console.ReadKey();

public class HotelBooking
{
  public string GuestName;
  public DateTime StartDate;
  public DateTime EndDate;

  public HotelBooking(string guestName, DateTime startDate, int lengthOfStayInDays)
  {
    GuestName = guestName;
    StartDate = startDate;
    EndDate = StartDate.AddDays(lengthOfStayInDays);
  }
}

// var rectangle1 = new Rectangle(5,2);
// var rectangle2 = new Rectangle(4,9);

// System.Console.WriteLine($"{rectangle1.Width}");
// System.Console.WriteLine($"{rectangle1.Height}");
// System.Console.WriteLine($"{rectangle2.Width}");
// System.Console.WriteLine($"{rectangle2.Height}");



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