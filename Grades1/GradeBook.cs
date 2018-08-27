using System;
using System.Collections.Generic;
using System.Text;

namespace Grades1
{
    public class GradeBook
    {

        public GradeBook()
        {
            grades = new List<float>();
        }
        public void AddGrade(float grade)
        {

            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
        }

        public GradeStatistics ComuteStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0f;

            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                //if(grade > stats.HighestGrade)
                //{
                //    stats.HighestGrade = grade;
                //}
                sum += grade;
            }

            stats.AverageGrade = sum / grades.Count;
            return stats;

        }

        public string Name;

        private List<float> grades;

    }

}