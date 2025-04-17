using Train;
try
{
	Console.Write("Please Enter a DateTime : ");
	DateTime date = DateTime.Parse(Console.ReadLine());
	Console.WriteLine($"Your Time Changed to the Persian Calendar : {Tools.PersianDate(date)}");
}
catch (FormatException)
{
	Console.WriteLine("Invalid Input!");
}
Console.ReadKey();


Console.WriteLine("hello world");