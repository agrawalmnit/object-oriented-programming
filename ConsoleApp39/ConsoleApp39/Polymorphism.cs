//using System;

//namespace ConsoleApp39;

//class Program
//{

//    class Polymorphism  // Base class (parent) 
//{
//    public void Sound()
//    {
//        Console.WriteLine("the Buzzer makes a sound");
//    }
//}

//class Pig : Polymorphism  // Derived class (child) 
//{
//    public void Sound()
//    {
//        Console.WriteLine("The buzzer1 says");
//    }
//}

//class Dog : Polymorphism  // Derived class (child) 
//{
//    public void Sound()
//    {
//        Console.WriteLine("The buzzer2 says");
//    }
//}


//    static void Main(string[] args)
//    {
//        Polymorphism myPolymorphism = new Polymorphism();  // Create a Animal object
//        Polymorphism myBuzzer = new Buzzer();  // Create a Pig object
//        Polymorphism myBuzzer2 = new Buzzer2();  // Create a Dog object

//        myPolymorphism.animalSound();
//        myBuzzer.Sound();
//        myBuzzer2.Sound();
//    }
//}