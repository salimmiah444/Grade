﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades1
{
    public class ThrowAwayGradeBook : GradeBook
    {
        public ThrowAwayGradeBook(string name)
            :base(name)
        {
            Console.WriteLine("Throw away ctor");
        }
        public override void DoSomething()
        {
            
        }

        public override GradeStatistics ComuteStatistics()
        {
            Console.WriteLine("Throwaway Compute");
            float lowest = float.MaxValue;
            foreach (float grade in _grades)
            {
                lowest = Math.Min(lowest, grade);
            
            }
            _grades.Remove(lowest);
            return base.ComuteStatistics();
        }
    }
}
