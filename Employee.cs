using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Employee
    {
        private int Id = Random.Shared.Next(1000, 5000);
        private string _name;
        private string _phone;
        private string _address;
        private decimal _salary;

        public string Name { get { return _name; } set { _name = value; } }
        public string Phone { get { return _phone; } set { _phone = value; } }
        public string Address { get { return _address; } set { _address = value; } }
        public decimal Salary { get { return _salary; } set { _salary = value; } }

        public Employee(string name, string phone, string address, decimal salary)
        {

            Name = name;
            Phone = phone;
            Address = address;
            Salary = salary;

        }
        public Employee() : this("", "", "", 0)
        {

        }
        public void SetSalary(decimal salary)
        {
            if (salary > 6000)
            {
                Salary = salary;
            }
            else
            { Salary = 6000; }
        }

        public void SetPhone(string phone)
        {
            if (phone.StartsWith("010") || phone.StartsWith("011") || phone.StartsWith("012") || phone.StartsWith("015"))
            {
                int phoneNo;
                if (int.TryParse(phone, out phoneNo) && phone.Length == 11)
                {
                    Phone = phone;
                }
                else
                {
                    Console.WriteLine("Phone must be 11 numbers !");
                }
            }
            else
            {
                Console.WriteLine("Invalid Phone !");
            }
        }
        public void IncreaseSalary(decimal amount)
        {
            Salary += amount;
        }
        public void Display()
        {
            Console.WriteLine($"Employee Id : {Id}.\n" +
                $"Name : {Name}.\n" +
                $"Address : {Address}.\n" +
                $"Phone : {Phone}.\n" +
                $"Salary : {Salary}.");
        }
    }
}
