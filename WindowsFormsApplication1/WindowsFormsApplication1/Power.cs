using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public static class Power
    {
        public static string Calculate(int x, int n) => 
        (x < 0 || x > 999) ? "Error: x must be in [0..999]" 
        : (n < 1 || n > 100) ? "Error: n must be in [1..100]" 
        : Math.Pow(x, n).ToString();
    }
}
