using System;

namespace Challenge1
{
  class Program
  {
    static void Main(string[] args)
    {
    //Following asks for and prints the users name.
	
    Console.WriteLine("Enter name:");
    string name = Console.ReadLine();
    Console.WriteLine("Name is: " + name);
    
    //Following asks for and prints users age.
    
    Console.WriteLine("Enter your age:");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Your age is: " + age);
    
    //Following adds a user given number to the users age.
    
    Console.WriteLine("Enter number to add to age:");
    int myNumber = Convert.ToInt32(Console.ReadLine());
    int a = age, b = myNumber;
    int sum = a + b;
    Console.WriteLine("Your new number is: " + sum);
    }
  }
}