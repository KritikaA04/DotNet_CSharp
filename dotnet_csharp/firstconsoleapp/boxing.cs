namespace firstconsoleapp
{
    class Typeconv
    {
        public static void Main()
        {
            int i=10;
            float f=i;
            f=78.23f;
            i= (int)f;
            string s=i.ToString();
            object o=i;
            o=s;
            f=float.Parse(Console.ReadLine());
            System.Console.WriteLine(o);
            System.Console.WriteLine(f);
            System.Console.WriteLine(i);
        }
    }
}