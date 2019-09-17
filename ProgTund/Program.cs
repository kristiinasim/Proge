using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgTund
{
    class Invoice
    {
        public int Id { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime? InvoiceDue { get; set; }

        public IList<InvoiceLine> Lines { get; set; }

        public Invoice()
        {
            Lines = new List<InvoiceLine>()
            {
                new InvoiceLine{Id=1,LineItem="Coca-Cola",Amount=1,sum=1},
                new InvoiceLine{Id=1,LineItem="Leib",Amount=1,sum=1},
                new InvoiceLine{Id=1,LineItem="Coca-Cola",Amount=1,sum=1},
                new InvoiceLine{Id=1,LineItem="Coca-Cola",Amount=1,sum=1}
            };
        }
    }

    class InvoiceLine
    {
        public int Id { get; set; }
        public string LineItem { get; set; }
        public double sum { get; set; }
        public int Amount { get; internal set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var invoices = new[]
            {
                new Invoice
                {
                    Id=1,
                    InvoiceNo = "2019/01",
                    InvoiceDate=DateTime.Now.Date,
                    InvoiceDue=DateTime.Now.AddDays(14).Date
                 }
            };

            Console.WriteLine("\r\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
