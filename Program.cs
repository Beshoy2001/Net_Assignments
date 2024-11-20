using System.ComponentModel;

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

            //decimal degree;
            //Console.WriteLine("Type your degree: ");
            //degree = Convert.ToDecimal(Console.ReadLine());

            //if (degree <= 50)
            //{
            //    Console.WriteLine("You FAIL !");
            //}
            //else if (degree <= 65)
            //{
            //    Console.WriteLine("You get Fair :");
            //}
            //else if (degree <= 75)
            //{
            //    Console.WriteLine("You are GOOD.");
            //}
            //else if (degree <= 85)
            //{
            //    Console.WriteLine("You are Very GOOD.");
            //}
            //else
            //{
            //    Console.WriteLine("You are EXCELLENT.");
            //}
            //Console.WriteLine("********************************************************");

            //int choice;
            //char proceed;

            //do
            //{
            //    Console.WriteLine("Choose : \n\n" +
            //                      "1) Good Morning. \n2) Good Evening. \n3) Good Afternoon. \n4) Good Night.");
            //    choice = Convert.ToInt32(Console.ReadLine());
            //    switch (choice)
            //    {
            //        case 1:
            //            Console.WriteLine("Good Morning.");
            //            break;
            //        case 2:
            //            Console.WriteLine("Good Evening.");
            //            break;
            //        case 3:
            //            Console.WriteLine("Good Afternoon.");
            //            break;
            //        case 4:
            //            Console.WriteLine("Good Night.");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid Choice !.");
            //            break;
            //    }
            //    Console.WriteLine("Do you want to continue ? ( y / n ) : ");
            //    proceed = Convert.ToChar(Console.ReadLine());

            //} while (proceed == 'y');
            #endregion

            #region Third Assignment

            //decimal number1, number2, addition, subtract, multiply, division;

            //Console.WriteLine("Type number 1: ");
            //number1 = Convert.ToDecimal(Console.ReadLine());

            //Console.WriteLine("Type number 2: ");
            //number2 = Convert.ToDecimal(Console.ReadLine());

            //addition = Add(number1, number2);
            //subtract = Subtract(number1, number2);
            //multiply = Multiply(number1, number2);


            //Console.WriteLine($"Sum : {addition} \nSubtract: {subtract} \n" +
            //                  $"Multiply: {multiply}");
            //if (number2 == 0m)
            //{
            //    Console.WriteLine("Division : Sorry, can not divide by zero!");
            //}
            //else
            //{
            //    division = Divide(number1, number2);
            //    Console.WriteLine($"Division: {division}");
            //}
            //Console.WriteLine("*************************************************");

            //int size, number, numberOfOcurrence;
            //int[] array;


            //Console.Write("Type the size of the integer array: ");
            //size = Convert.ToInt32(Console.ReadLine());

            //array = new int[size];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write($"Type number {i + 1} : ");
            //    array[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.Write("Type number to count its occurrence :");
            //number = Convert.ToInt32(Console.ReadLine());

            //numberOfOcurrence = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (number == array[i])
            //    {
            //        numberOfOcurrence++;
            //    }
            //}
            //Console.WriteLine($"The number {number} occurred {numberOfOcurrence} time(s);");
            //Console.WriteLine("*****************************************************************");

            //int sizeOfArray;
            //int[] arr;
            //Console.Write("Type the size of the integer array to reverse: ");
            //sizeOfArray = Convert.ToInt32(Console.ReadLine());
            //arr = new int[sizeOfArray];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Type number {i + 1} : ");
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < arr.Length / 2; i++)
            //{
            //    int temp = arr[arr.Length - 1 - i];
            //    arr[arr.Length - 1 - i] = arr[i];
            //    arr[i] = temp;
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"Number {i + 1} = {arr[i]}");
            //}
            //Console.WriteLine("*****************************************************************");

            //int _sizeOfArray;
            //int[] _arr;
            //bool[] _indexes;
            //Console.Write("Type the size of the integer array to remove duplicates: ");
            //_sizeOfArray = Convert.ToInt32(Console.ReadLine());
            //_arr = new int[_sizeOfArray];
            //_indexes = new bool[_sizeOfArray];

            //for (int i = 0; i < _arr.Length; i++)
            //{
            //    Console.Write($"Type number {i + 1} : ");
            //    _arr[i] = Convert.ToInt32(Console.ReadLine());
            //    _indexes[i] = true;
            //}

            //for (int i = 0; i < _arr.Length; i++)
            //{
            //    int temp = _arr[i];

            //    for (int j = i + 1; j < _arr.Length; j++)
            //    {
            //        if (temp == _arr[j])
            //        {
            //            _indexes[j] = false;
            //        }

            //    }
            //}
            //Console.WriteLine("\nNon Duplicate Numbers are :");
            //for (int i = 0; i < _indexes.Length; i++)
            //{
            //    if(_indexes[i] == true)
            //    {
            //        Console.WriteLine($"Number {i + 1} : {_arr[i]}");
            //    }
            //}


            #endregion

            #region OOP Day1
            Employee emp = new Employee();
            emp.Name = "Ahmed";
            emp.Address = "Address of Ahmed";
            emp.SetSalary(4000);
            emp.SetPhone("01226056541");
            emp.IncreaseSalary(500);
            emp.Display();

            Console.WriteLine("*******************************************");
            Employee[] employees = new Employee[3];
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = new Employee();
                Console.Write($"Type name of employee {i + 1} : ");
                employees[i].Name = Console.ReadLine();
                Console.Write("Type address : ");
                employees[i].Address = Console.ReadLine();
                Console.Write("Type Phone number : ");
                string phone = Console.ReadLine();
                employees[i].SetPhone(phone);
                Console.Write("Type Salary : ");
                employees[i].SetSalary(Convert.ToDecimal(Console.ReadLine()));
                Console.Write("Type salary increment : ");
                employees[i].IncreaseSalary(Convert.ToDecimal(Console.ReadLine()));

                Console.WriteLine("\n*****************************\nEmployee Details :");
                employees[i].Display();
                Console.WriteLine("****************************************************\n");
            }

            #endregion
        }

        #region Third Assignment
        private static decimal Add(decimal number1, decimal number2)
        {
            decimal result = number1 + number2;
            return result;
        }
        private static decimal Subtract(decimal number1, decimal number2)
        {
            decimal result = number1 - number2;
            return result;
        }
        private static decimal Multiply(decimal number1, decimal number2)
        {
            decimal result = number1 * number2;
            return result;
        }
        private static decimal Divide(decimal number1, decimal number2)
        {
            decimal result = number1 / number2;
            return result;
        }
        #endregion
    }
}
