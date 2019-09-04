using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    class Program
    {
        private const int MaxValue = 10;
        private const int Digit = 3;

        static void Main(string[] args)
        {
            // 1 정답을 생성한다.
            Random random = new Random();
            int[] answers = new int[Digit];

            while (true)
            {
                for (int i = 0; i < Digit; i++)
                    answers[i] = random.Next(MaxValue);

                if (answers[0] != answers[1] && answers[1] != answers[2] && answers[2] != answers[0])
                    break;
            }

            Console.WriteLine("[정답]");
            for (int i = 0; i < Digit; i++)
                Console.Write(" " + answers[i]);
            Console.WriteLine();


            int tryCount = 0;
            while (true)
            {
                tryCount++;


                // 2 추측을 입력받는다
                int[] guesses = new int[Digit];
                for (int i = 0; i < Digit; i++)
                    guesses[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("[추측]");
                for (int i = 0; i < Digit; i++)
                    Console.Write(" " + guesses[0]);
                Console.WriteLine();


                // 3 결과를 계산한다
                int strike = 0;
                int ball = 0;
                int @out = 0;

                for (int i = 0; i < Digit; i++)
                {
                    int j = (i + 1) % Digit;
                    int k = (i + 2) % Digit;

                    if (guesses[i] == answers[i])
                        strike++;
                    else if (guesses[i] == answers[j] || guesses[i] == answers[k])
                        ball++;
                    else
                        @out++;
                }


                // 4 결과를 출력한다.
                Console.WriteLine($"S:{strike}, B:{ball}, O:{@out}");


                // 5 3S가 아니면 2번으로 돌아간다.
                if (strike == Digit)
                    break;
            }


            // 6 도전횟수를 출력한다.
            Console.WriteLine($"{tryCount} 회");
        }
    }
}
