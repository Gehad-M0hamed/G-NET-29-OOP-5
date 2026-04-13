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

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
