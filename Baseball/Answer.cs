using System;

namespace Baseball
{
    public class Answer
    {
        public Answer()
        {
            _numbers = new int[Constant.Digit];
        }

        private int[] _numbers;

        private string _prefix = "[정답]";

        public void Print()
        {
            Console.WriteLine(_prefix);
            for (int i = 0; i < Constant.Digit; i++)
                Console.Write(" " + _numbers[i]);
            Console.WriteLine();
        }

        public int this[int index] // indexer
        {
            get
            {
                return _numbers[index];
            }
        }

        public void Create()
        {
            Random random = new Random();

            while (true)
            {
                for (int i = 0; i < Constant.Digit; i++)
                    _numbers[i] = random.Next(Constant.MaxValue);

                if (_numbers[0] != _numbers[1] && _numbers[1] != _numbers[2] && _numbers[2] != _numbers[0])
                    break;
            }
        }
    }
}
