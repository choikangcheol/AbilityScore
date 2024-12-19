using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbilityScore
{
    internal class AbilityScoreCalculator
    {
        public int RollResult = 14; // 굴리기 값
        public double DivideBy = 1.75;
        public int AddAmount = 2;
        public int Minimum = 3;
        public int Score;
        
        public void CalculateAbilityScore()
        {
            // 굴리기 값을 DivideBy 필드 값으로 나눕니다.
            double divided = RollResult / DivideBy;

            // AddAmount를 나눗셈 결과에 더합니다.
            int added = AddAmount += (int)divided;

            // 결과 값이 너무 작으면 Minimum 값을 사용합니다.
            if (added < Minimum)
            {
                Score = Minimum;
            }
            else
            {
                Score = added;
            }
        }
    }
}
