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

<<<<<<< HEAD
        public int Order { get; set; }
=======
        // public int Order { get; set; }
        //靜態變數對於這個類別來說，類別內的所有人都共用這個靜態變數
        public static int Order { get; set; }
>>>>>>> origin/master

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
            if (this.Length > B.Length)
                return 1 * Order;
            else if (this.Length == B.Length)
                return 0;
            else
                return -1 * Order;

            //return (int)(this.Length - B.Length);
        }

        public override string ToString()
        {
            string s = string.Format("X={0}, Y={1}, Length={2}", this.X, this.Y, this.Length);
            return s;
        }
    }
}