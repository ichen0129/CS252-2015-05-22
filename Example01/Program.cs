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
            /*
            Vector[] vectors = new Vector[5];
            vectors[0] = new Vector(8, 4);
            vectors[1] = new Vector(7, 24);
            vectors[2] = new Vector(5, 12);
            vectors[3] = new Vector(2, 1);
            vectors[4] = new Vector(3, 8);
            */
            Student[] students = new Student[5];
            students[0] = new Student(80, 95, 60, "小明");
            students[1] = new Student(52, 80, 77, "小英");
            students[2] = new Student(90, 78, 62, "小華");
            students[3] = new Student(66, 75, 74, "小寶");
            students[4] = new Student(65, 99, 66, "大寶");

            Console.Write("請指定排序科目，(1)國文 (2)英文 (3)數學 (4)總分");
            int SubjectOption = int.Parse(Console.ReadLine());

            Console.Write("請指定排序的順序，(1)小到大，(2)大到小:");
            int OrderOption = int.Parse(Console.ReadLine());

            Student.排序科目 = SubjectOption;
            Student.Order = OrderOption == 1 ? 1 : -1;
            Console.WriteLine("排序前");
            for (int index = 0; index < students.Length; index++)
            {
                Console.WriteLine(students[index]);
            }

            Console.WriteLine("排序後");
            Array.Sort(students);
            for (int index = 0; index < students.Length; index++)
            {
                Console.WriteLine(students[index]);
            }

            /*
            //for (int index = 0; index < vectors.Length; index++)
            // {
            //     vectors[index].Order = OrderOption == 1 ? 1 : -1;
            //}*
            Vector.Order = OrderOption == 1 ? 1 : -1;
            Console.WriteLine("排序前");
            for (int index = 0; index < vectors.Length; index++)
            {
                Console.WriteLine(vectors[index]);
            }

            Console.WriteLine("排序後");
            Array.Sort(vectors);
            for (int index = 0; index < vectors.Length; index++)
            {
                Console.WriteLine(vectors[index]);
            }
             */
        }
    }
}