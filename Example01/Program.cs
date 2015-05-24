using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Vector[] vectors = new Vector[5];
            vectors[0] = new Vector(3, 4);
            vectors[1] = new Vector(7, 24);
            vectors[2] = new Vector(5, 12);
            vectors[3] = new Vector(2, 1);
            vectors[4] = new Vector(3, 8);
            Console.WriteLine("排序前");
            for (int index = 0; index < vectors.Length; index++)
            {
                Console.WriteLine(vectors[index].ToString());
            }

            Console.WriteLine("排序後");
            Array.Sort(vectors);
            for (int index = 0; index < vectors.Length; index++)
            {
                Console.WriteLine(vectors[index].ToString());
            }
        }
    }
}