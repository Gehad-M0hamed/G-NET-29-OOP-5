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

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
