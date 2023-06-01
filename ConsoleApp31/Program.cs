namespace ConsoleApp31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables and then initialize to zero.
    int num1 = 0; int num2 = 0;

    // Display title as the C# console calculator app.
    Console.WriteLine("Console Calculator in C#\r");
    Console.WriteLine("------------------------\n");

    // Ask the user to type the first number.
    Console.WriteLine("Напишите число и нажмите Enter");
    num1 = Convert.ToInt32(Console.ReadLine());

    // Ask the user to type the second number.oghi
    Console.WriteLine("Напишите другое число и нажмите Enter");
    num2 = Convert.ToInt32(Console.ReadLine());

    // Ask the user to choose an option.
    Console.WriteLine("Выберите операцию из списка ниже:");
    Console.WriteLine("\t+ - Сумма");
    Console.WriteLine("\t- - Разность");
    Console.WriteLine("\t* - Умножение");
    Console.WriteLine("\t/ - Деление");
    Console.Write("Ваша операция? ");

    // Use a switch statement to do the math.
    switch (Console.ReadLine())
    {
        case "+":
            Console.WriteLine($"Сумма равна: {num1} + {num2} = " + (num1 + num2));
            break;
        case "-":
            Console.WriteLine($"Разность равна: {num1} - {num2} = " + (num1 - num2));
            break;
        case "*":
            Console.WriteLine($"Произведение равно: {num1} * {num2} = " + (num1 * num2));
            break;
        case "/":
            Console.WriteLine($"Частное равно: {num1} / {num2} = " + (num1 / num2));
            break;
    }
    // Wait for the user to respond before closing.
    Console.Write("Нажмите любую клавишу чтоб закрыть приложение калькулятора...");
    Console.ReadKey();
        }
    }
}