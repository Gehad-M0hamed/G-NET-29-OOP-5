using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_29_OOP_5
{
    public class StandardTicket : Ticket
    {
        public override void PrintDetails(int id)
        {
            Console.WriteLine($"[Ticket #{id}] {MovieName} | Standard | Seat: {Seat} | Price: {Price} | After Tax: {PriceAfterTax:F1} | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        public override object Clone()
        {
            return new StandardTicket
            {
                MovieName = this.MovieName,
                Price = this.Price,
                Seat = this.Seat,
                IsBooked = this.IsBooked
            };
        }
    }

    public class VipTicket : Ticket
    {
        public bool HasLounge { get; set; }
        public double LoungeFee { get; set; }

        public override void PrintDetails(int id)
        {
            Console.WriteLine($"[Ticket #{id}] {MovieName} | VIP | Lounge: {(HasLounge ? "Yes" : "No")} | Fee: {LoungeFee} | Price: {Price} | After Tax: {PriceAfterTax + LoungeFee:F1} | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        public override object Clone()
        {
            return new VipTicket
            {
                MovieName = this.MovieName,
                Price = this.Price,
                Seat = this.Seat,
                IsBooked = this.IsBooked,
                HasLounge = this.HasLounge,
                LoungeFee = this.LoungeFee
            };
        }
    }

    public class ImaxTicket : Ticket
    {
        public bool Is3D { get; set; }

        public override void PrintDetails(int id)
        {
            Console.WriteLine($"[Ticket #{id}] {MovieName} | IMAX | 3D: {(Is3D ? "Yes" : "No")} | Price: {Price} | After Tax: {PriceAfterTax:F1} | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        public override object Clone()
        {
            return new ImaxTicket
            {
                MovieName = this.MovieName,
                Price = this.Price,
                Seat = this.Seat,
                IsBooked = this.IsBooked,
                Is3D = this.Is3D
            };
        }
    }
}
