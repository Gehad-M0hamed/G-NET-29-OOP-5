using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_29_OOP_5
{
    public abstract class Ticket : IPrintable, IBookable, ICloneable
    {
        public string MovieName { get; set; }
        public double Price { get; set; }
        public string Seat { get; set; }
        public bool IsBooked { get; set; }

        public double PriceAfterTax => Price * 1.14;

        public void Book() => IsBooked = true;
        public void Cancel() => IsBooked = false;

        public abstract void PrintDetails(int id);
        public abstract object Clone();
    }
    public interface IPrintable
    {
        void PrintDetails(int id);
    }

    public interface IBookable
    {
        bool IsBooked { get; set; }
        void Book();
        void Cancel();
    }

}
