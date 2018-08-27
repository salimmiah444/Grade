using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades1
{
    class Program
    {
        //static void GiveBookAName(ref GradeBook book)
        //{
        //    //book = new GradeBook();
        //    //book.Name = "The New Grade book ";
        //}

        //static void IncrementNumber(ref int number)
        //{
        //    number = 42;
        //}


        static void Main(string[] args)
        {
            //Arrays();

            //SpechSynthesizer
            //Immutable();
            //NewMethod();


            //string name1 = "Scott";
            //string name2 = "scott";

            //bool areEqual = name1.Equals(name2, StringComparison.CurrentCultureIgnoreCase);

            //Console.WriteLine(areEqual);




            GradeBook book = new GradeBook();
            book.AddGrade(91f);
            book.AddGrade(89.5f);
            book.AddGrade(75f);

            GradeStatistics stats = book.ComuteStatistics();
            WriteNames("Scott","Allen","Alex","joy");
            int number = 20;
            WriteBytes(number); 
            WriteBytes(stats.AverageGrade);
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.LowestGrade);
            Console.WriteLine(stats.HighestGrade);
        }

        private static void WriteBytes(int value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            NewMethod(bytes);
        }

        private static void WriteBytes(float value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            NewMethod(bytes);
        }

        private static void NewMethod(byte[] bytes)
        {
            foreach (byte b in bytes)
            {

                Console.Write("0x{0:X} ", b);
            }

            Console.WriteLine();
        } 
        private static void WriteNames(params string[] names)
        {

            foreach (string name in names )
            {
                Console.WriteLine(name);
            }

        }
        //private static void Arrays()
        //{
        //    float[] grades;
        //    grades = new float[3];

        //    AddGrades(grades);

        //    foreach (float grade in grades)
        //    {

        //        Console.WriteLine(grade);
        //    }



        //}

        //private static void AddGrades(float[] grades)
        //{
        //    if (grades.Length >= 3)
        //    {
        //        grades[0] = 91f;
        //        grades[1] = 89.1f;
        //        grades[2] = 75f;
        //    }
        //}

        //private static void Immutable()
        //{
        //    string name = " Scott ";
        //    name = name.Trim();

        //    DateTime date = new DateTime(2014, 1, 1);
        //    date = date.AddHours(25);

        //    Console.WriteLine(date);
        //    Console.WriteLine(name);
        //}

        //private static void NewMethod()
        //{
        //    GradeBook g1 = new GradeBook();
        //    GradeBook g2 = g1;

        //    GiveBookAName(ref g2);
        //    Console.WriteLine(g2.Name);

        //    //g1 = new GradeBook();
        //    //g1.Name = "Scott's book";


        //    int x1 = 0;
        //    IncrementNumber(ref x1);
        //    Console.WriteLine(x1);
        //    //int x2 = x1;

        //    //x1 = 100;
        //}
    }
}

