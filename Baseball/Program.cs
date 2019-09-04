using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 정답을 생성한다.
            Random random = new Random();
            int answer0;
            int answer1;
            int answer2;

            while (true)
            {
                answer0 = random.Next(10);
                answer1 = random.Next(10);
                answer2 = random.Next(10);

                if (answer0 != answer1 && answer1 != answer2 && answer2 != answer0)
                    break;
            }

            Console.WriteLine("[정답]");
            Console.Write(" " + answer0);
            Console.Write(" " + answer1);
            Console.Write(" " + answer2);
            Console.WriteLine();



            // 2 추측을 입력받는다

            // 3 결과를 계산한다

            // 4 결과를 출력한다.

            // 5 3S가 아니면 2번으로 돌아간다.

            // 6 도전횟수를 출력한다.
        }
    }
}
