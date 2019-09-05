using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    public abstract class NumberContainer
    {
        public NumberContainer()
        {
            _numbers = new int[Constant.Digit];
        }

        protected int[] _numbers;

        protected abstract string GetPrefix();

        public void Print()
        {
            Console.WriteLine(GetPrefix());
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
    }
}
