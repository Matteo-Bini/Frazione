using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Frazione
{
    internal class Frazione
    {
        public int N { get; set; }
        public int D { get; set; }
        public void Fraz(int n, int d)
        {
            N = n;
            D = d;
        }
        public void MCD()
        {
            if(N > D)
            {
                for(int i = D; i == 1; i--)
                {
                    if (N % i == 0 && D % i == 0)
                    {
                        N = N / i;
                        D = D / i;
                        break;
                    }
                    else if ((N % i != 0 || D % i != 0))
                        continue;
                    else
                        break;
                }
            }
            else if( N == D)
            {
            N = 1; D = 1;
            }
            else
            {
                for (int i = N; i == 0; i--)
                {
                    if (D % i == 0 && D % i == 0)
                    {
                        N = N / i;
                        D = D / i;
                        break;
                    }
                    else if(D % i != 0 || N % i != 0)
                        continue;
                    else
                        break;
                }
            }

        }
        public override string ToString()
        {
            return string.Format ("{0} \n{1}", N, D);
        }


    }
}
