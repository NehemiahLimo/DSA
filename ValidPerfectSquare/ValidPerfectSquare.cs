using System;

namespace ValidPerfectSquare
{
    class ValidPerfectSquare
    {
        public bool IsPerfectSquare(int num)
        {
            int l = 1; int r = num;
            while (l <= r)
            {
                int mid = (l + r) / 2;
                if (mid * mid > num)
                {
                    r = mid - 1;
                }
                else if (mid * mid < num)
                {
                    l = mid + 1;
                }
                else
                {
                    return true;
                }

            }
            return false;
        }
        static void Main(string[] args)
        {
            ValidPerfectSquare v = new ValidPerfectSquare();
            bool result =v.IsPerfectSquare(9);
            Console.WriteLine("Is it a perfect square?: "+result);
        }
    }
}
