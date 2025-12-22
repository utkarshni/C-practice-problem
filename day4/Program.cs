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
/*using Day20DemoConsole;
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
*/
//Accept height in cm. If < 150 (Dwarf), 150-165 (Average), 165-190 (Tall), >190 (Abnormal)
/*using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your height");
        int height = int.Parse(Console.ReadLine());
        if (height < 150)
        {
            Console.WriteLine("Dwarf");
        }
        else if (height >= 150 && height < 165)
        {
            Console.WriteLine("Average");
        }
        else if (height >= 165 && height <= 190)
        {
            Console.WriteLine("Tall");
        }
        else
        {
            Console.WriteLine("Abnormal");
        }
    }
}*/
//Take three integers and find the maximum using nested if
/*using System;

class Program
{
    static void Main()
    {
        int a, b, c;

        Console.Write("Enter first number: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        b = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        c = int.Parse(Console.ReadLine());

        if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine("Maximum number is: " + a);
            }
            else
            {
                Console.WriteLine("Maximum number is: " + c);
            }
        }
        else
        {
            if (b > c)
            {
                Console.WriteLine("Maximum number is: " + b);
            }
            else
            {
                Console.WriteLine("Maximum number is: " + c);
            }
        }
    }
}*/
//Determine if a year is leap (Divisible by 400 OR (Divisible by 4 and NOT 100))
/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the year:");
        int year = int.Parse(Console.ReadLine());

        if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
        {
            Console.WriteLine("Leap year");
        }
        else
        {
            Console.WriteLine("Not a leap year");
        }
    }
}
*/
//Display the first N terms of the Fibonacci sequence
/*using System;

class Program
{
    static void Main()
    {
        int n, a = 0, b = 1, c;

        Console.Write("Enter number of terms: ");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("Fibonacci sequence:");

        for (int i = 1; i <= n; i++)
        {
            Console.Write(a + " ");

            c = a + b;
            a = b;
            b = c;
        }
    }
}*/
//Find the Greatest Common Divisor and Least Common Multiple of two numbers.
/*using System;

class Program
{
    static void Main()
    {
        int a, b, x, y, gcd, lcm;

        Console.Write("Enter first number: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        b = int.Parse(Console.ReadLine());

        x = a;
        y = b;

        // Find GCD using Euclidean Algorithm
        while (y != 0)
        {
            int temp = y;
            y = x % y;
            x = temp;
        }

        gcd = x;

        // Formula to find LCM
        lcm = (a * b) / gcd;

        Console.WriteLine("GCD = " + gcd);
        Console.WriteLine("LCM = " + lcm);
    }
}*/
/*using PersonMngmtSystem;
PersonBL sBLobj = new PersonBL();
//clr takes care of exception , we through it , it takes care of it
sBLobj.AcceptPersonDetails();//order of these methods cannot be changed
//sBLobj.CalcTotal();
//sBLobj.CalcAvg();
int t1;
float p1;
sBLobj.CalcResult(out t1, out p1);// though the function is void it will still return 2 values due to out , one for t1 and one for p1
System.Console.WriteLine($"Total{t1}");//string interpulation
System.Console.WriteLine($"Percentage{p1}");*/
/*using InterfaceDemoProj;
IAdd m1 = new MathClass();//ALok - add(function)
ISub m2 = new MathClass();//Riya - Add,sub
IAll m3 = new MathClass();//rajat - Add,sub , prod, div*/
using System;
using InterfaceDemoProj;
Product pObj=new Product();
pObj.ProdID =101;
pObj.name= "Bottle";
pObj.Price=850;
//approch 2
Product pObj1 =new Product(){ProdID =105,name="Pen",Price=50};//object initilazer
//approch 3
List<Product> ProdList = new List<Product>()
{
    new Product(){ProdID =103,name="Pencil",Price=10},
    new Product(){ProdID =104,name="book",Price=250},
    new Product(){ProdID =106,name="toy car",Price=450},
    new Product(){ProdID =107,name="bag",Price=950},
    new Product(){ProdID =108,name="scale",Price=20},
    new Product(){ProdID =109,name="eraser",Price=10}
};
//generic(like unisex) and non generic(array,and here boxing and unboxing happens which degreates the performace and that is why we have list. it is particular for something)
foreach(var item in ProdList)
{
    System.Console.WriteLine($"{item.ProdID}\t{item.name}\t{item.Price}");
}






