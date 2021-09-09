using System;
using System.Collections.Generic;

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
                    //Console.WriteLine("yay");
                    return true;

                }
                else
                {
                    //Console.WriteLine("nay");
                    return false;
                }
            }
            else
            {
                //Console.WriteLine("nay");
                return false;
            }
            //return year % 4 == 0 && (year % 400 == 0 || year % 100 != 0);
        }
    }
}
