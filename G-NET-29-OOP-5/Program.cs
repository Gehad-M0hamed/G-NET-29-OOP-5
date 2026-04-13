using System;
using System.Collections.Concurrent;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace G_NET_29_OOP_5
{
    internal class Program
    {

        #region Q1:
        //*An interface defines a contract that a class must follow.
        //  It specifies what a class can do, not how it does it.
        //*because Concrete Classes lead to Tight Coupling,interfaces 
        //    provides High flexibility.
        //* Benefits:
        //    Polymorphism
        //    Loose Coupling
        //    Multiple Inheritance
        //    make Testing easier.

        #endregion

        #region Q2:
        //a) Naming Conflict, IEnglishSpeaker, IArabicSpeaker have Greet() 
        //    doing  2 interfaces  at same time ,,leads to print Hello / Ahlan.

        //b)Explicit Interface Implementation:
        //     Right code:
        //    class Translator : IEnglishSpeaker, IArabicSpeaker
        //{

        //    void IEnglishSpeaker.Greet()
        //    {
        //        Console.WriteLine("Hello");
        //    }

        //    void IArabicSpeaker.Greet()
        //    {
        //        Console.WriteLine("Ahlan");
        //    }
        //}
        //c)No,because Greet() there be hidden and it belongs to itis interface.
        //    -----------------------------
        //IEnglishSpeaker english = new Translator();
        //english.Greet(); // print  Hello
        //    ---------------------------
        //    IArabicSpeaker arabic = (IArabicSpeaker)new Translator();
        //arabic.Greet(); // print Ahlan

        #endregion

        #region Q3:
        // * shallow copy:
        //    copies the obj but copies references 
        //     for reference-type fields.
        //     When would you use:
        //     object is immutable.
        //     no nested reference state.
        //     performance the first Priority.
        //     -------------------------------------
        // *deep copy:
        //    copies the obj and all nested objects, 
        //     creating fully independent duplicates.
        //    When would you use:
        //    when we need to completely isolate obj from each other,
        //    so  we ensure that modifications in  new version will not affect the original.
        //-------------------------------------------
        //* Data Corruption 
        //   original and copy share the same reference to internal objects
        //   any modification made by object 2 
        //     data auto change at abj 1
        //     that leads to small errors we cant determine it easily.
        #endregion

        #region Q4:
        //Dev - Testing
        //QA - Testing
        //   Explaination:
        //    **Title: Because strings in C# are immutable, when modified second instance,
        //    they became completely separet  from the first instance, 
        //    and the orig title unchanged.
        //    ** Dept: This is the problem .
        //     at surface copying,  new partition isn't created,
        //     only the partition's "title" is copied.

        #endregion

        #region Part 02:
        static void Main(string[] args)
        {
        
                Cinema myCinema = new Cinema();
                myCinema.Open();

                var t1 = new StandardTicket { MovieName = "Inception", Seat = "A5", Price = 80 };
                var t2 = new VipTicket { MovieName = "Avengers", Seat = "B1", Price = 200, HasLounge = true, LoungeFee = 50 };
                var t3 = new ImaxTicket { MovieName = "Dune", Seat = "C10", Price = 130, Is3D = true };

                t1.Book();
                t2.Book();
                t3.Book();

                myCinema.Tickets.Add(t1);
                myCinema.Tickets.Add(t2);
                myCinema.Tickets.Add(t3);

                myCinema.PrintAll();

                Console.WriteLine("\n--- Clone Test ---");
                Console.Write("Original : "); t2.PrintDetails(2);

                VipTicket t4 = (VipTicket)t2.Clone();
                t4.MovieName = "Interstellar";
                t4.IsBooked = false;

                Console.Write("Clone    : "); t4.PrintDetails(4);

                Console.WriteLine("\n--- After Cancellation ---");
                t1.Cancel();
                t1.PrintDetails(1);

                IPrintable[] ticketsArray = { t1, t2, t3 };
                BookingHelper.PrintAll(ticketsArray);

                myCinema.Close();
            

    }
        #endregion
    }
}
