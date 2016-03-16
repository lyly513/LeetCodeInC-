using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInC_Sharp
{
    public class Solution
    {
        public bool CanWinNim(int n)
        {
            if (n % 4 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
