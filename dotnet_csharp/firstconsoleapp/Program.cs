// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

namespace firstconsoleapp
{
    class Sample
    {
        public static void main()
        {
            Console.WriteLine("Enter your name");
            string? empname= Console.ReadLine();
            System.Console.WriteLine("Enter your age");
            int age=Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter your DOB");
            DateTime dob=Convert.ToDateTime(Console.ReadLine());
            System.Console.WriteLine("Enter your salary");
            float sal= float.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter if the information is true?");
            Boolean res= Convert.ToBoolean(Console.ReadLine());

            System.Console.WriteLine("Name: "+empname);
            System.Console.WriteLine($"Age: {age}");
            System.Console.WriteLine("DOB: {0} and Salary: {1}",dob.ToShortDateString(), sal);
            System.Console.WriteLine("The info is: "+res);
            while(age<25)
            {
                Console.WriteLine("yet to be 25");
                age++;
            }
        }
    }
}