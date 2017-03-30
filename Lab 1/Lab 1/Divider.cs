using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public static class Divider
    {
        public static string Divide(double x, double y) =>
            (x < 0 || x > 999)
            ? "Error: x must be in [0..999]"
            : (y < 0 || y > 100)
            ? "Error: y must be in (0..100]"
            : (y == 0)
            ? "Error: you cannot divide by 0 in this Universe!"
            : (x / y).ToString();
    }
}
