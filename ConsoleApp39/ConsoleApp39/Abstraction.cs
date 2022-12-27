//using System;

//namespace ConsoleApp39;
//class Program
//{


//    // Abstract class
//    abstract class Abstraction
//{
//    // Abstract method (does not have a body)
//    public abstract void Sound();
//    // Regular method
//    public void sleep()
//    {
//        Console.WriteLine("Zzz");
//    }
//}

//// Derived class (inherit from Animal)
//class Window : Abstraction
//    {
//    public override void Sound()
//    {
//        // The body of animalSound() is provided here
//        Console.WriteLine("the sleep sound of window ");
//    }
//}


//    static void Main(string[] args)
//    {
//        Window myWindow = new Window(); // Create a Pig object
//        myWindow.Sound();  // Call the abstract method
//        myWindow.sleep();  // Call the regular method
//    }
//}