////A user can implement function overloading by defining two or more functions in a class sharing the same name.
////C# can distinguish the methods with different method signatures.
////i.e.
////the methods can have the same name but with different parameters list





//using System;
//using System.Collections.Generic;
//using System.Diagnostics.CodeAnalysis;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp39
//{
//    public class Method_Overloading
//    {
//        public int Add(int a, int b)
//        {
//            int sum = a + b;
//            return sum;
//        }
//        public int Add(int a, int b, int c)
//        {
//            int sum = a + b + c;
//            return sum;
//        }
//        public static void Main(string[] args)
//        {
//            Method_Overloading ob= new Method_Overloading();
//            int sum1 = ob.Add(1, 2);
//            Console.WriteLine(sum1);

//            int sum2 = ob.Add(1,2, 3);
//            Console.WriteLine(sum2);
//        }
//    }
//}
