using System;
using System.Collections.Generic;
using System.Text;

namespace Grades1
{
    public class GradeStatistics
    {
        public GradeStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }
        public float LowestGrade;
        public float AverageGrade;
        public float HighestGrade;
    }
}