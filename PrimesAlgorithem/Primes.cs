using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental.PrimesAlgorithem
{
    class Primes
    {
        private long min;
        
        private long max;
        
        public Primes() : this(2, 1000000) { }
        
        public Primes(long minimum, long maximum)
        {
            min = minimum < 2 ? 2 : minimum;
            max = maximum;
        }

        public IEnumerator GetEnumerator()
        {
            for(long possiablePrim = min; possiablePrim < max; possiablePrim++)
            {
                bool isPrime = true;
                // 只能被2和自己整除 取值范围在2和自己的平方根之间
                for(long possibleFactor = 2; possibleFactor <= Math.Floor(Math.Sqrt(possiablePrim)); possibleFactor++)
                {
                    long remainderAfterDivision = possiablePrim % possibleFactor;
                    if(remainderAfterDivision == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    // 只有素数才可以生成返回
                    yield return possiablePrim;
                }
            }
        }

    }
}
