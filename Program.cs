namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Assignment
            //Console.WriteLine("Hello, World!");
            //decimal number1, number2;

            //Console.WriteLine("Type number 1: ");
            //number1 = Convert.ToDecimal(Console.ReadLine());

            //Console.WriteLine("Type number 2: ");
            //number2 = Convert.ToDecimal(Console.ReadLine());

            //Console.WriteLine($"Sum : {number1 + number2} \n Subtract: {number1 - number2} \n" +
            //                  $" Multiply: {number1 * number2}");
            //if (number2 == 0m)
            //{
            //    Console.WriteLine("Division : Sorry, can not divide by zero!");
            //}
            //else
            //{
            //    Console.WriteLine($"Division: {number1 / number2}");
            //}
            //Console.WriteLine("*************************************************");

            //string firstName, LastName;
            //Console.WriteLine("Type First Name: ");
            //firstName = Console.ReadLine();
            //Console.WriteLine("Type Last Name: ");
            //LastName = Console.ReadLine();

            //Console.WriteLine($"Your Full Name is: {firstName} {LastName} \n" +
            //                  $"The Full Name has {(firstName + LastName).Length} letters");
            //Console.WriteLine("Thanks");
            #endregion

            #region Second Assignment

            decimal degree;
            Console.WriteLine("Type your degree: ");
            degree = Convert.ToDecimal(Console.ReadLine());

            if (degree <= 50)
            {
                Console.WriteLine("You FAIL !");
            }
            else if (degree <= 65)
            {
                Console.WriteLine("You get Fair :");
            }
            else if (degree <= 75)
            {
                Console.WriteLine("You are GOOD.");
            }
            else if (degree <= 85)
            {
                Console.WriteLine("You are Very GOOD.");
            }
            else
            {
                Console.WriteLine("You are EXCELLENT.");
            }
            Console.WriteLine("********************************************************");

            int choice;
            char proceed;
           
            do
            {
                Console.WriteLine("Choose : \n\n" +
                                  "1) Good Morning. \n2) Good Evening. \n3) Good Afternoon. \n4) Good Night.");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Good Morning.");
                        break;
                    case 2:
                        Console.WriteLine("Good Evening.");
                        break;
                    case 3:
                        Console.WriteLine("Good Afternoon.");
                        break;
                    case 4:
                        Console.WriteLine("Good Night.");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice !.");
                        break;
                }
                Console.WriteLine("Do you want to continue ? ( y / n ) : ");
                proceed = Convert.ToChar(Console.ReadLine());

            } while (proceed == 'y');
            #endregion
        }
    }
}
