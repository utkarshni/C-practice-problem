// See https://aka.ms/new-console-template for more information
//using system is a package
/*public class Code
{
    public static void Main()// garbage collector will never collect tha variable or line that has static
    {
        Console.WriteLine("enter your name: ");
        string? name = Console.ReadLine();
        Console.WriteLine("Hello, " + name + "!");
    }
}*/
//Code.Main(); // class name.function name() // if i want to run in other file
/*using System;

class Program
{
    static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;

        for (int i = 3; i * i <= n; i += 2)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        string? input = Console.ReadLine();

        // Convert input to integer safely
        int num = Convert.ToInt32(input); // null becomes 0

        if (IsPrime(num))
            Console.WriteLine($"{num} is a prime number.");
        else
            Console.WriteLine($"{num} is not a prime number.");
    }
}*/
//this code is for try parse
/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter age: ");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int age))
        {
            bool isAdult = age >= 18;
            Console.WriteLine("Adult? " + isAdult);
        }
        else
        {
            Console.WriteLine("Invalid age. Please enter a whole number.");
        }
    }
}*/
/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter radius: ");//write take u to the next line while write keeps u there only
        string? input = Console.ReadLine();

        if (!double.TryParse(input, out double radius))
        {
            Console.WriteLine("Invalid input");
            return;
        }

        if (radius < 0)
        {
            Console.WriteLine("Radius cannot be negative.");
            return;
        }

        double area = 3.14 * radius * radius;
        Console.WriteLine($"Area of circle = {area:F2}");
    }
}*/
/*static void Menu()
{
    Console.WriteLine("1. Add Student details");
    Console.WriteLine("1. Update Student details");
    Console.WriteLine("1. Drop Student details");
}
//Console.WriteLine("hello");
Student sobj = new Student(123,"Alok","Delhi");
sobj.DisplayDetails(sobj);
sobj=new Student(123,"alok","chennai");
sobj.DisplayDetails(sobj);
string[] cities={"Pune","agra","mumbai","goa","banglore"};
int i=0;
do
{
    Menu();
    System.Console.WriteLine("enter choice:");
    i = Int32.Parse(Console.ReadLine());
    switch (i)
    {
        case 1:
        {
            break;
        }
        case 2:
        {
            break;
        }
        case 3:
        {
            break;        
        }
    }

}
while (true);

while (i < cities.Length)
{
    System.Console.WriteLine(cities[i]);
    i++;
}*/
//purpose is just to print the details use foreach , if the purpose is to print n add or edit we use for loop
using Day20DemoConsole;
static void Menu()
{
    Console.WriteLine("1. Add Student details");
    Console.WriteLine("1. Update Student details");
    Console.WriteLine("1. Drop Student details");
}
Console.WriteLine("Hello, World!");
Student sObj = new Student(123,"Alok","Delhi");
sObj.DisplayDetails(sObj);

sObj = new Student(123,"Alok","Mumbai"); // another object is existing in the memory now this not right approach override exits
sObj.DisplayDetails(sObj);

string[] cities = {"Pune","Chennai","Agra","Amritsar","Mumbai"};
//Using while loop
// int i=0;
// while (i < cities.Length)
// {
// Console.WriteLine(cities[i]);
// i++;
// }

// using for each loop
foreach(var item in cities)
{
    System.Console.WriteLine(item);
}
int choice = 0;
do{
    Menu();
    Console.WriteLine("Enter choice: ");
    choice = Int32.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
        {
            break;
        }
        case 2:
        {
            break;
        }
        case 3:
        {
            break;        
        }
    }

}
while (true);


