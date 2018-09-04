﻿using System;
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

        public string Description
        {
            get
            {
                string result;
                switch(LetterGrade)
                {
                    case 'A' :
                        result = "Excellent";
                        break;
                    case 'B':
                        result = "Above average";
                        break;
                    case 'C':
                        result = "Average";
                        break;
                    case 'D':
                        result = "Below Average";
                        break;
                    default:
                        result = "Fail";
                        break;
                }
                return result;

            }

        }

        public char  LetterGrade
        {
            get
            {
                char result;
                if(AverageGrade >= 90)
                {
                    result = 'A';
                }
                else if(AverageGrade >= 80)
                {
                    result = 'B';
                }
                else if(AverageGrade >= 70)
                {
                    result = 'C';
                }
                else if(AverageGrade >= 60)
                {
                    result = 'D';
                }
                else
                {
                    result = 'F';
                }

                return result;
            }

        }
    }
}