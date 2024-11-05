namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            decimal number1, number2;
            
            Console.WriteLine("Type number 1: ");
            number1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Type number 2: ");
            number2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Sum : {number1 + number2} \n Subtract: {number1 - number2} \n" +
                              $" Multiply: {number1 * number2}");
            if (number2 == 0m)
            {
                Console.WriteLine("Division : Sorry, can not divide by zero!");
            }
            else
            {
                Console.WriteLine($"Division: {number1 / number2}");
            }
            Console.WriteLine("*************************************************");

            string firstName, LastName;
            Console.WriteLine("Type First Name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Type Last Name: ");
            LastName = Console.ReadLine();

            Console.WriteLine($"Your Full Name is: {firstName} {LastName} \n" +
                              $"The Full Name has {(firstName + LastName).Length} letters");
            Console.WriteLine("Thanks");
        }
    }
}
