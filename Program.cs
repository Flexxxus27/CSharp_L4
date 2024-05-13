namespace CSharp_L4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public abstract class CDA
    {
        public abstract void B(int x);
        public virtual void A() { }
        public void asd(int x) { }
    }


    public class ABC 
    { 
        public ABC() { }
        public virtual void A() { }
        public abstract void B(int x);
    }

    public class BCA : ABC
    {
        public BCA() : base() { }
    }

}
