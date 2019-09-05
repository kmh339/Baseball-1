using System;

namespace Baseball
{
    class Program
    {
        static void Main(string[] args)
        {
           // TDD (Test-Driven Development, 테스트 주도 개발)

            // 1 정답을 생성한다.
            Answer answer = new Answer();
            answer.Create();

            answer.Print();
            
            int tryCount = 0;
            while (true)
            {
                tryCount++;


                // 2 추측을 입력받는다
                Guess guess = new Guess();
                guess.Input();

                guess.Print();


                // 3 결과를 계산한다
                Result result = new Result();
                result.Calculate(answer, guess);


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
