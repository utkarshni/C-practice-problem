using System;

namespace QuickMart
{
    class Program
    {
        static SaleTransaction LastTransaction;
        static bool HasLastTransaction = false;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n================== QuickMart Traders ==================");
                Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
                Console.WriteLine("2. View Last Transaction");
                Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateTransaction();
                        break;

                    case "2":
                        ViewLastTransaction();
                        break;

                    case "3":
                        CalculateProfitLoss();
                        break;

                    case "4":
                        Console.WriteLine("Thank you. Application closed normally.");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please select between 1 and 4.");
                        break;
                }
            }
        }
        public static void CreateTransaction()
        {
            SaleTransaction txn = new SaleTransaction();

            Console.Write("Enter Invoice No: ");
            txn.InvoiceNo = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(txn.InvoiceNo))
            {
                Console.WriteLine("Invoice number cannot be empty.");
                return;
            }

            Console.Write("Enter Customer Name: ");
            txn.CustomerName = Console.ReadLine();

            Console.Write("Enter Item Name: ");
            txn.ItemName = Console.ReadLine();

            Console.Write("Enter Quantity: ");
            if (!int.TryParse(Console.ReadLine(), out int qty) || qty <= 0)
            {
                Console.WriteLine("Quantity must be greater than 0.");
                return;
            }
            txn.Quantity = qty;

            Console.Write("Enter Purchase Amount (Total): ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal purchaseAmt) || purchaseAmt <= 0)
            {
                Console.WriteLine("Purchase amount must be greater than 0.");
                return;
            }
            txn.PurchaseAmount = purchaseAmt;

            Console.Write("Enter Selling Amount (Total): ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal sellingAmt) || sellingAmt < 0)
            {
                Console.WriteLine("Selling amount must be 0 or more.");
                return;
            }
            txn.SellingAmount = sellingAmt;

            txn.CalculateProfitLoss();

            LastTransaction = txn;
            HasLastTransaction = true;

            Console.WriteLine("Transaction saved successfully.");
        }
        public static void ViewLastTransaction()
        {
            if (!HasLastTransaction)
            {
                Console.WriteLine("No transaction available. Please create a new transaction first.");
                return;
            }

            PrintInvoice(LastTransaction);
        }
        public static void CalculateProfitLoss()
        {
            if (!HasLastTransaction)
            {
                Console.WriteLine("No transaction available. Please create a new transaction first.");
                return;
            }

            LastTransaction.CalculateProfitLoss();
            PrintInvoice(LastTransaction);
        }
        public static void PrintInvoice(SaleTransaction txn)
        {
            Console.WriteLine("\n----------- Last Transaction  -----------");
            Console.WriteLine($"Invoice No        : {txn.InvoiceNo}");
            Console.WriteLine($"Customer Name     : {txn.CustomerName}");
            Console.WriteLine($"Item Name         : {txn.ItemName}");
            Console.WriteLine($"Quantity          : {txn.Quantity}");
            Console.WriteLine($"Purchase Amount   : {txn.PurchaseAmount:F2}");
            Console.WriteLine($"Selling Amount    : {txn.SellingAmount:F2}");
            Console.WriteLine($"Status            : {txn.ProfitOrLossStatus}");
            Console.WriteLine($"Profit/Loss Amt   : {txn.ProfitOrLossAmount:F2}");
            Console.WriteLine($"Profit Margin %   : {txn.ProfitMarginPercent:F2}%");
            Console.WriteLine("---------------------------------------");
        }
    }
}
