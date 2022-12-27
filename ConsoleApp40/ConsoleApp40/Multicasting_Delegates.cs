//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp40
//{
//    internal class Multicasting_Delegates
//    {
//        public delegate void rectDelegate(double height, double width);

//        public void area(double height, double width)
//        {
//            Console.WriteLine("Area : {0}", (width * height));
//        }

//        public void perimeter(double height, double width)
//        {
//            Console.WriteLine("perimeter : {0}", 2 * (height+width));
//        }

//        public static void Main(string[] args)
//        {
//            Multicasting_Delegates rect = new Multicasting_Delegates();

//            //rect.perimeter(3.9, 4.9);
//            //rect.area(9.9, 10.9);

//            rectDelegate rectDele = new rectDelegate(rect.area);

//            rectDele += rect.perimeter;

//            rectDele.Invoke(6.3, 4.5);

//            Console.WriteLine();

//            rectDele.Invoke(9.8, 7.8);


//        }
//    }
//}
