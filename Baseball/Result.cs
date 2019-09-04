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

        public void Calculate(int[] answers, int[] guesses)
        {
            for (int i = 0; i < Constant.Digit; i++)
            {
                int j = (i + 1) % Constant.Digit;
                int k = (i + 2) % Constant.Digit;

                if (guesses[i] == answers[i])
                    strike++;
                else if (guesses[i] == answers[j] || guesses[i] == answers[k])
                    ball++;
                else
                    @out++;
            }
        }
    }
}
