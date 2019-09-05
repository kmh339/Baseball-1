using System;

namespace Baseball
{
    public class Answer : NumberContainer
    {
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
        
        protected override string GetPrefix()
        {
            return "[정답]";
        }

    }
}
