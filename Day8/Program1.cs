using System;
 namespace DemoOnCollection
{
    class Program
    {
        public void ArrayDemoFunc()
        {
            // Integer arrays
            int[] arrNum = new int[5];
            int[] arrNum1 = new int[3] { 10, 20, 30 };

            // String array
            string[] cities = { "Delhi", "Chennai", "Trichi", "Agra", "Pune", "Coorg", "Meerut" };

            // Customer array
            Customer[] custArray = new Customer[2];

            // Initialize first customer
            custArray[0] = new Customer();
            custArray[0].ID = 101;
            custArray[0].Name = "Alok";

            // Initialize Billing Address
            custArray[0].BillingAddress = new Address();
            custArray[0].BillingAddress.FlatNo = "1802";
            custArray[0].BillingAddress.BuildingName = "Sky Towers";
            custArray[0].BillingAddress.Street = "Paradise Apartment";
            custArray[0].BillingAddress.City = "Pune";

            // Output
            Console.WriteLine("Customer Details:");
            Console.WriteLine($"ID: {custArray[0].ID}");
            Console.WriteLine($"Name: {custArray[0].Name}");
            Console.WriteLine($"City: {custArray[0].BillingAddress.City}");
        }

        static void Main(string[] args)
        {
            Program progObj = new Program();
            progObj.ArrayDemoFunc();

            Console.ReadLine();
        }
    }
}
//for refernce type new keyword is alwaysrequired to call from object

 

           /* foreach(var item in cities)
            {
                if (item.Length > 4)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(item);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(item);
                }
            }

        }
        static void Main(string[] args)
        {
            Program progObj = new Program();
            progObj.ArrayDemoFunc();//non static function can be called in static function but visa versa not possible
        }
    }
}*/















