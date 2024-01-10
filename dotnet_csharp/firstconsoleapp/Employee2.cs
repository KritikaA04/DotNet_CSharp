using firstconsoleapp;

namespace another
{
    class Employee2
    {
        public static void main()
        {
            Test t=new Test();
            Employee e1= new Employee();
            e1.Accept();
            // e1.Eid= -100;
            // e1.Display();
            t.Display(e1);
            System.Console.WriteLine(e1.Empname);
            System.Console.WriteLine(e1.Eid);
            System.Console.WriteLine(e1.Salary);
        }
    }
}