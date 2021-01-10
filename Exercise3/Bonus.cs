using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Bonus
    {
        public double GetBonusRateBySeniority(int seniority) // По идее это можно было и в свойсто запихнуть.
        {
            if (seniority < 1)
            {
                return 1;
            } else if (seniority < 3)
            {
                return 1.1D;
            } else if ( seniority < 5)
            {
                return 1.2D;
            } else
            {
                return 1.3D;
            }
        }
    }
}
