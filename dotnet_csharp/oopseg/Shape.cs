namespace oopseg
{
    class Shape
    {
         public string Color{get;set;} 
         public float Area{get;set;}

        public virtual void Accept()
        {
            System.Console.WriteLine("Enter Color:");
            Color=Console.ReadLine();
        }

        public virtual void Calcarea()
        {

        }
        public virtual void Display()
        {
            System.Console.WriteLine("the color is:"+Color);
        }
    }

    class Rectangle:Shape 
    {
        // no multiple inheritence 
        public int Length{get;set;}
        public int Breadth{get;set;}

        public new void Accept()
        {
            // base.Accept();
            System.Console.WriteLine("enter Length and Breadth:");
            Length= Convert.ToInt32(Console.ReadLine());
            Breadth= Convert.ToInt32(Console.ReadLine());
        }

        public new void Calcarea()
        {
            Area= Length*Breadth;
        }
        public new void Display()
        {
            // base.Display();
            System.Console.WriteLine("The area is:"+Area);
        }
    }


    class Circle:Shape 
    {
        // no multiple inheritence 
        public int Radius{get;set;}
        

        public override void Accept()
        {
            base.Accept();
            System.Console.WriteLine("enter Length and Breadth:");
            Radius= Convert.ToInt32(Console.ReadLine());
            
        }

        public  void Calcarea()
        {
            // Area= float.Parse((3.14*Radius*Radius).ToString());
            Area= (float)(3.14 *Radius*Radius);
        }
        public override void Display()
        {
            base.Display();
            System.Console.WriteLine("The area is:"+Area);
        }
    }
    

}