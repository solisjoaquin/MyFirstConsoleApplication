// See https://aka.ms/new-console-template for more information

string myName = "Joaquin";
string myLocation = "Argentina";

Console.WriteLine("My name is " + myName);
Console.WriteLine("I am from " + myLocation);

Console.WriteLine($"The current date is {DateTime.Now.ToString("MM/dd/yyyy")}");

DateTime christmas = new DateTime(2023, 12, 25);
TimeSpan daysUntilChristmas = christmas - DateTime.Now;

Console.WriteLine($"There are {daysUntilChristmas.Days} days until Christmas!");

double width, height, woodLength, glassArea;
string widthString, heightString;
Console.WriteLine("Enter the width of the window in feet: ");
widthString = Console.ReadLine();
width = double.Parse(widthString);
Console.WriteLine("Enter the height of the window in feet: ");
heightString = Console.ReadLine();   
height = double.Parse(heightString);
woodLength = 2 * (width + height) * 3.25;
glassArea = 2 * (width * height);
Console.WriteLine("The length of the wood is " + woodLength + " feet");
Console.WriteLine("The area of the glass is " + glassArea + " square metres");
Console.ReadKey();