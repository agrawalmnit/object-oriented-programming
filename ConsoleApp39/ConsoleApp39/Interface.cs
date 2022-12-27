// the interface only contains the signature of properties and methods 
// it defines the name and data type for each property
// and the name and return value for each method 





//using System;

//namespace ConsoleApp39;

//public class Interface
//{
//    public interface ISampleInterface
//    {
//        void SampleMethod();
//    }

//   public class ImplementationClass : ISampleInterface
//    {
//        // Explicit interface member implementation:
//        void ISampleInterface.SampleMethod()
//        {
//            // Method implementation.
//        }

        
//    }
//    public interface IPoint
//    {
//        // Property signatures:
//        int X { get; set; }

//        int Y { get; set; }

//        double Distance { get; }
//    }

//   public class Point : IPoint
//    {
//        // Constructor:
//        public Point(int x, int y)
//        {
//            X = x;
//            Y = y;
//        }

//        // Property implementation:
//        public int X { get; set; }

//        public int Y { get; set; }

//        // Property implementation
//        public double Distance =>
//           Math.Sqrt(X * X + Y * Y);
//    }

    

//    public static void Main(string[] args)
//    {
//        // Declare an interface instance.

//        ISampleInterface obj = new ImplementationClass();

//         static void PrintPoint(IPoint p)
        
//        {
         
//            Console.WriteLine("x={0}, y={1}", p.X, p.Y);
        
//        }

//        // Call the member.a

//        obj.SampleMethod();
        
//        IPoint p = new Point(2, 3);
        
//        Console.Write("My Point: ");
        
//        PrintPoint(p);
    
//    }



//}
