//trapezoid area calculator
try
{

	Console.WriteLine("Welcome to the trapezoid area calculator ");

	Console.WriteLine("Please enter the major base: ");
	double B_M = Convert.ToDouble(Console.ReadLine());

	Console.WriteLine("Please enter the minor base: ");
	double B_m = Convert.ToDouble(Console.ReadLine());

	Console.WriteLine("Please enter the height: ");
	double height = Convert.ToDouble(Console.ReadLine());

	double area = ((B_M + B_m) * height) / 2;
	Console.WriteLine("The area of your trapezoid is: " + area);
}
catch(FormatException)
{
	Console.WriteLine("The entry is not valid, be sure to enter numbers.  ");

}