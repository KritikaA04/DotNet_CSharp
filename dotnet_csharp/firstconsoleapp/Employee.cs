using System;
using System.Dynamic;

namespace firstconsoleapp
{
    class Employee
    {
        // member variables- private
        int eid;
        string empname;
        float salary;
        DateTime dob;
        
        public int Eid
        {
            get{return eid;}
            set
            {
                if(value<0)
                    eid =0;
                else
                    eid = value;
            }
        }
        public float Salary
        {
            get{return salary;}
        }

        public string Empname
        {
            get{return empname;}
            set{empname=value;}
        }

        public Employee()
        {
            salary=4000;
        }
        public void Accept()
        {
            Console.WriteLine("Enter your name");
            empname= Console.ReadLine();
            System.Console.WriteLine("Enter your eid");
            eid=Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter your DOB");
            dob=Convert.ToDateTime(Console.ReadLine());
            // System.Console.WriteLine("Enter your salary");
            // salary= float.Parse(Console.ReadLine());
        }
    }
    class Test 
    {
        public void Display(Employee e)
        {
            System.Console.WriteLine("Name: "+e.Empname);
            System.Console.WriteLine($"ID: {e.Eid}");
            // System.Console.WriteLine("DOB: {0} and Salary: {1}",dob.ToShortDateString(), salary);
            System.Console.WriteLine("Salary: "+e.Salary);
            e=null;
        }
    }
        

    
}