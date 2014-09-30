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
        const int MaxNumberOfGuesses = 7;

        public void Initialize()
        {
            Random randomNumber = new Random();
            _number = randomNumber.Next(1, 101);
            _count = 0;
        }

    }
}
