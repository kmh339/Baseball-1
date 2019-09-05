using System;

namespace Baseball
{
    public class Guess : NumberContainer
    {
        public void Input()
        {
            for (int i = 0; i < Constant.Digit; i++)
                _numbers[i] = int.Parse(Console.ReadLine());
        }

        protected override string GetPrefix()
        {
            return "[추측]";
        }
    }
}