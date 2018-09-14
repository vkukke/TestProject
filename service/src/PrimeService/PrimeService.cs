using System;

namespace PrimeService
{
    public class PrimeService
    {
        public bool IsPrime(int num)
        {
            if (num <= 2)
              return true;
            throw new NotImplementedException();
        }
    }
}
