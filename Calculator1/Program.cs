int num1;
int num2;
int result;
string operation;
Console.WriteLine("Hello, Welcome to the calculator program!");
Console.WriteLine("Please enter your first number");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter your second number");
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What type of operation wouuld you like to do");
Console.WriteLine("Please enter a for addition, and s for subtraction, m for multiplication,or any other key for division.");
operation = Console.ReadLine();
switch (operation)
{
    case "a":
        result = num1 + num2;
        Console.WriteLine($"The Result is {result}");
        break;
    case "s":
        result = num1 - num2;
        Console.WriteLine($"The Result is {result}");
        break;
    case "m":
        result = num1 * num2;
        Console.WriteLine($"The Result is {result}");
        break;
    default:
        result = num1 / num2;
        Console.WriteLine($"The Result is {result}");
        break;
}
Console.WriteLine("Thank you for using the Calculator program");
Console.ReadKey();  // This will make the program wait until a key is pressed

