using System;

namespace Baseball
{
    class Program
    {
        /// <summary>
        /// 숫자들을 출력한다.
        /// </summary>
        /// <param name="prefix">숫자들을 출력하기 전 표시할 텍스트</param>
        /// <param name="numbers">출력할 숫자들</param>
        private static void PrintNumbers(string prefix, int[] numbers)
        {
            Console.WriteLine(prefix);
            for (int i = 0; i < Constant.Digit; i++)
                Console.Write(" " + numbers[i]);
            Console.WriteLine();


            Console.WriteLine(prefix);
                for (int i = 0; i < Constant.Digit; i++)
                    Console.Write(" " + numbers[i]);
                Console.WriteLine();

        }

        static void Main(string[] args)
        {
            // 1 정답을 생성한다.
            Random random = new Random();
            int[] answers = new int[Constant.Digit];

            while (true)
            {
                for (int i = 0; i < Constant.Digit; i++)
                    answers[i] = random.Next(Constant.MaxValue);

                if (answers[0] != answers[1] && answers[1] != answers[2] && answers[2] != answers[0])
                    break;
            }

            PrintNumbers("[정답]", answers);
            
            int tryCount = 0;
            while (true)
            {
                tryCount++;


                // 2 추측을 입력받는다
                int[] guesses = new int[Constant.Digit];
                for (int i = 0; i < Constant.Digit; i++)
                    guesses[i] = int.Parse(Console.ReadLine());

                PrintNumbers("[추측]", guesses);


                // 3 결과를 계산한다
                Result result = new Result();
                result.Calculate(answers, guesses);


                // 4 결과를 출력한다.
                result.Print();


                // 5 정답이라면 게임을 끝낸다.
                if (result.IsCorrect())
                    break;
            }


            // 6 도전횟수를 출력한다.
            Console.WriteLine($"{tryCount} 회");
        }
    }
}
