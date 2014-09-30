using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L1A
{
    class SecretNumber
    {
        private int _count;
        private int _number;
        public const int MaxNumberOfGuesses = 7;

        public void Initialize()
        {
            Random randomNumber = new Random();
            _number = randomNumber.Next(1, 101);
            _count = 0;
        }

        public SecretNumber()
        {
            Initialize();
        }

        public bool MakeGuess(int number)
        {
            if (_count < MaxNumberOfGuesses)
            {
                if (number < _number)
                {
                    Console.WriteLine("{0} är för lågt. Du har {1} gissningar kvar", number, (MaxNumberOfGuesses - _count));
                    _count = _count + 1;
                    return false;
                }
                else if (number > _number)
                {
                    Console.WriteLine("{0} är för högt. Du har {1} gissningar kvar", number, (MaxNumberOfGuesses - _count));
                    _count = _count + 1;
                    return false;
                }
                else
                {
                    Console.WriteLine("RÄTT GISSAT! Du klarade det på {0} försök", _count);
                    return true;
                }
            }
            else
            {
                throw new ApplicationException();
            }
        }
    }
}
