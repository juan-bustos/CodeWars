using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class CompareTestAverages
    {
        public static bool BetterThanAverage (int[] ClassPoints, int MyPoints)
        {
            double sum = 0;

            for (int i = 0; i < ClassPoints.Length; i++)
            {
                sum += ClassPoints[i];
            }
            double totalScores = sum + MyPoints;
            double avgScore = totalScores / (ClassPoints.Length + 1);
            if (avgScore < MyPoints)
            {
                return true;
            }
            return false;
        }
    }
}
