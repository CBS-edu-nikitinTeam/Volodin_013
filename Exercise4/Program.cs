using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Invoice(123, "Some LTD1", "Some LTD2", "Product 2HD", 5, 200).GetInvoiceDetails());
        }
    }
}
