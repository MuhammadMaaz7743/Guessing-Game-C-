using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guessing_Game
{
    class Randoms
    {
        int a = 1;
        int c = 10097;
        int m;
        int x0 = 0;
        int x1 = 0;
        int[] RandomArray;

        public Randoms(int M)
        {
            m = M;
            Random r = new Random();
            x0 = r.Next(0 , m - 1);
        }

        public int[] next()
        {
            RandomArray = new int[m];
            for (int i = 0; i < m; i++)
            {
                x1 = ((a * x0) + c) % m;
                x0 = x1;
                RandomArray[i] = x1;
            }
            return RandomArray;
        }

    }
}
