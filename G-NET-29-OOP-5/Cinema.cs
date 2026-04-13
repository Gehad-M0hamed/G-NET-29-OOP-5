using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_29_OOP_5
{
    public class Cinema
    {
        public List<IPrintable> Tickets = new List<IPrintable>();

        public void Open() => Console.WriteLine("=== Cinema Opened ===\n");
        public void Close() => Console.WriteLine("\n=== Cinema Closed ===");

        public void PrintAll()
        {
            Console.WriteLine("--- All Tickets ---");
            for (int i = 0; i < Tickets.Count; i++)
            {
                Tickets[i].PrintDetails(i + 1);
            }
        }
    }
}
