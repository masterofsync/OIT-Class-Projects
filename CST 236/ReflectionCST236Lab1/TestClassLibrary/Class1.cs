using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestClassLibrary
{
    public class Class1
    {
        private string myString = "abce";
        private int myInteger = 54;

        private int GetSum(int x, int y)
        {
            return x + y;
        }

        private int GetSubtraction(int x, int y)
        {
            return x - y;
        }

        public int Sum(int x, int y)
        {
            return GetSum(x,y);
        }

        public int Subtraction(int x, int y)
        {
            return GetSubtraction(x, y);
        }

        public int Multiply(int x, int y)
        {
            return x*y;
        }

        public int Divide(int x, int y)
        {
            return x/y;
        }


    }
}
