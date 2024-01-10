using System;

namespace firstconsoleapp
{
    struct Stud
    {
        public int m1;
        public int m2;
    }
    class Datatype
    {
        public static void main()
        {
            Stud s1= new Stud();
            s1.m1=80;
            s1.m2=90;
            Stud s2=s1;
            System.Console.WriteLine("s1's mark1:"+s1.m1);
            System.Console.WriteLine("s1's mark1:"+s1.m2);
            System.Console.WriteLine("s2's mark1:"+s2.m1);
            System.Console.WriteLine("s2's mark1:"+s2.m2);
            s1.m1=90;
            s1.m2=100;
            System.Console.WriteLine("s1's mark1:"+s1.m1);
            System.Console.WriteLine("s1's mark1:"+s1.m2);
            System.Console.WriteLine("s2's mark1:"+s2.m1);
            System.Console.WriteLine("s2's mark1:"+s2.m2);

        }
    }
}