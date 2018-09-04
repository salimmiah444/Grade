using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Grades1
{
    public class GradeBook : GradeTracker  
    {

        public GradeBook(string name = "There is no name")
        {
            Console.WriteLine("gradebook ctor");
            Name = name;
            _grades = new List<float>();

        }
        public override void AddGrade(float grade)
        {

            if (grade >= 0 && grade <= 100)
            {
                _grades.Add(grade);
            }
        }

        public override GradeStatistics ComuteStatistics()
        {
            Console.WriteLine("GradeBook Compute");
            GradeStatistics stats = new GradeStatistics();

            float sum = 0f;

            foreach (float grade in _grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                //if(grade > stats.HighestGrade)
                //{
                //    stats.HighestGrade = grade;
                //}
                sum += grade;
            }

            stats.AverageGrade = sum / _grades.Count;
            return stats;

        }

        public override void WriteGuides(TextWriter textWriter)
        {
            textWriter.WriteLine("Grades:");
            int i = 0;
            do
            {
                textWriter.WriteLine(_grades[i]);
                i++;
            } while (i < _grades.Count);
                textWriter.WriteLine("*************");
            //while (i<_grades.Count)
            //{
            //    textWriter.WriteLine(_grades[i]);
            //    i++;
            //}
            //textWriter.WriteLine("*************");
            //for (int i = _grades.Count-1; i >= 0; i--)
            //{
            //    textWriter.WriteLine(_grades[i]);
            //}
            //textWriter.WriteLine("*************");
            //for (int i = 0; i < _grades.Count; i++)
            //{
            //    textWriter.WriteLine(_grades[i]);
            //}
            //textWriter.WriteLine("*************");
            //foreach (float grade in _grades)
            //{
            //    textWriter.WriteLine(grade);
            //}
            //textWriter.WriteLine("*************");
        }

        
       
        //public NamedChangedDeligate NameChanged;
        protected List<float> _grades;

    }

}