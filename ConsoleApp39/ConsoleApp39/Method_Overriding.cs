////Method Overriding is a technique that allows the invoking of functions from another class (base class) in the derived class.




//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp39
//{
//     class baseClass
//    {
//        public void show()
//        {
//            Console.WriteLine("base class");
//        }
//    }
//    class derived: baseClass {
//        new public void show()
//        {
//            Console.WriteLine("derived class");
//        }
//    }
//    class Method_Overriding
//    {
//        public static void main(string[] args)
//        {
//            baseClass obj = new baseClass();
//            obj.show();
//            obj = new derived();
//            obj.show();
//        }
//    }
//}
