////  A class is a user-defined blueprint or prototype from which objects are created.
////  Basically, a class combines the fields and methods(member function which defines actions) into a single unit



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp39
//{
//    public class Class_And_Object
//    {
        

//        // Instance Variables
//        String name;
//        String breed;
//        int age;
//        String color;

//        // Constructor Declaration of Class
//        public Class_And_Object(String name, String breed,
//                int age, String color)
//        {
//            this.name = name;
//            this.breed = breed;
//            this.age = age;
//            this.color = color;
//        }

//        // Property 1
//        public String getName()
//        {
//            return name;
//        }

//        // Property 2
//        public String getBreed()
//        {
//            return breed;
//        }

//        // Property 3
//        public int getAge()
//        {
//            return age;
//        }

//        // Property 4
//        public String getColor()
//        {
//            return color;
//        }

//        // Method 1
//        public String toString()
//        {
//            return ("Hi my name is " + this.getName()
//                    + ".\nMy breed, age and color are " + this.getBreed()
//                    + ", " + this.getAge() + ", " + this.getColor());
//        }

//        // Main Method
//        public static void Main(String[] args)
//        {

//            // Creating object
//            Class_And_Object tuffy = new Class_And_Object("x object", "y object", 5, "white");
//            Console.WriteLine(tuffy.toString());
//        }
//    }

//}

