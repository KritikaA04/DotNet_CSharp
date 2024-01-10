namespace oopseg
{
    class ShapeClient
    {
        public static void Main()
        {
            // Rectangle r= new Rectangle();
            Shape s= new Rectangle();
            s.Accept();
            // r.Getdetails();
            s.Calcarea();
            s.Display();
            // r.printArea();

            s = new Circle();
            s.Accept();
            // r.Getdetails();
            s.Calcarea();
            s.Display();
            // r.printArea();
        }
    }
}