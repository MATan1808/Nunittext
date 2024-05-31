using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
        public class PrimeChecker
    {
        private int number;
        public PrimeChecker(int number) { 
            this.number = number;
        }
        public int IsPrime(int number)
        {
            if (number <= 1) return 0;
            if (number == 2) return 1;
            if (number % 2 == 0) return 0;

            for (int i = 3; i * i <= number; i += 2)
            {
                if (number % i == 0) return 0;
            }
            return 1;
        }

    }
}
