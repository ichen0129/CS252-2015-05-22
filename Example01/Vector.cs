using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Vector : IComparable
    {
        public double X { get; set; }

        public double Y { get; set; }

        public double Length
        {
            get { return Math.Sqrt(X * X + Y * Y); }
        }

        public Vector(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public int CompareTo(object obj)
        {
            Vector B = obj as Vector;
            return (int)(this.Length - B.Length);
        }

        public override string ToString()
        {
            string s = string.Format("X={0}, Y={1}, Length={2}", this.X, this.Y, this.Length);
            return s;
        }
    }
}