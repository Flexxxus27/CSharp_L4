using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_L4
{
    public abstract class Geometric
    {
        public abstract double S();
        public abstract double P();

    }

    public class Triangle : Geometric
    {
        public int A{get; set;}
        public int B { get; set;}
        public int C { get; set;}

         public Triangle(int A, int B, int C) 
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }   
        public override double S() 
        {
            return A * B * C;
        }
        public override double P()
        {
            return A + B + C;
        }
    }

    public class Squere : Geometric
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }

        public Squere(int A, int B, int C, int D)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
        }
        public override double S()
        {
            return A * B * C * D;
        }
        public override double P()
        {
            return A + B + C + D;
        }
    }
}
