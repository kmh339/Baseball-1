using System;

namespace Baseball
{
    public class Guess
    {
        private int[] _numbers;

        private string _prefix = "[추측]";

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

        public void Input()
        {
            int[] guesses = new int[Constant.Digit];
            for (int i = 0; i < Constant.Digit; i++)
                guesses[i] = int.Parse(Console.ReadLine());
        }
    }
}