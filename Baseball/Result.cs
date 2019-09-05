using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    public class Result // public, internal
    {
        public int strike = 0;
        public int ball = 0;
        public int @out = 0;

        public bool IsCorrect()
        {
            return strike == Constant.Digit;
        }

        public void Print()
        {
            Console.WriteLine($"S:{strike}, B:{ball}, O:{@out}");
        }

        public void Calculate(Answer answer, Guess guess)
        {
            for (int i = 0; i < Constant.Digit; i++)
            {
                int j = (i + 1) % Constant.Digit;
                int k = (i + 2) % Constant.Digit;

                if (guess[i] == answer[i])
                    strike++;
                else if (guess[i] == answer[j] || guess[i] == answer[k])
                    ball++;
                else
                    @out++;
            }
        }
    }
}
