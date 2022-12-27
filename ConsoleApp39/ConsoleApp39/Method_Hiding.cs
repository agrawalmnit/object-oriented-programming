////In method hiding,you can hide the implementation of the methods of a base class from the derived class using the new keyword.
////Or in other words,in method hiding,you can redefine the method of the base class in the derived class by using the new keyword.




//using System;

//namespace ConsoleApp39
//{
//    public class My_Family
//    {

//        public void member()
//        {
//            Console.WriteLine("Total number of family members: 3");
//        }
//    }

//    // Derived Class
//    public class My_Member : My_Family
//    {

        
//        public new void member()
//        {
//            Console.WriteLine("Name: ishansi, Age: 21 \nName: sohan, "
//                            + "Age: 22 \nName: rohan, Age: 20 ");
//        }
//    }

//    public class Method_Hiding
//    {

        
//        public static void Main(string[] args)
//        {

            
//            My_Member obj = new My_Member();

            
//            obj.member();
//        }
//    }
//}
