using System;

namespace assignment0
{
    public class leapyear
    {
        public static bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 400 == 0 || year % 100 != 0)
                {

                    return true;

                }
                else
                {

                    return false;
                }
            }
            else
            {

                return false;
            }
            //return year % 4 == 0 && (year % 400 == 0 || year % 100 != 0);
        }
        public static void Main2(string[] args)
        {


            Console.WriteLine("Hello World!");
        }
    }
}
