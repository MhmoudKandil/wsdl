using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
 

namespace RedBillLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(Namespace = "http://KnockKnock.readify.net")]
    public class RedPill : IRedPill
    {

        public Guid WhatIsYourToken()
        {
            Guid g;
            g = new Guid("8073a2a6-d318-442b-ba1a-5697a2eea230");
            return g;
        }
      


        //public CompositeType GetDataUsingDataContract(CompositeType composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue)
        //    {
        //        composite.StringValue += "Suffix";
        //    }
        //    return composite;
        //}


        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            TriangleType ret;
            //ret = TriangleType.Error;
           // return ret;
            int Longest = Math.Max(a, Math.Min(b, c));
            int minimum = Math.Min(a, Math.Min(b, c));
            long sum = a + b + c;
            int midium = (int)(sum - Longest - minimum);

            ///  int circle1_x = 0;
            ///  int circle1_y = 0;
            ///  int circle1_r = minimum;
            ///
            ///  int circle2_x = Longest;
            ///  int circle2_y = 0;
            ///  int circle2_r = minimum;
            ///
            ///  long delta_radius_squared = (circle1_r - circle2_r);
            ///  delta_radius_squared *= delta_radius_squared;
            ///
            ///  long delta_radiusSum_squared = (circle1_r + circle2_r);
            ///  delta_radiusSum_squared *= delta_radiusSum_squared;
            ///
            ///  long delta_x_squared = circle1_x - circle2_x;
            ///  delta_x_squared *= delta_x_squared;
            ///
            ///  long delta_y_squared = circle1_y - circle2_y;
            ///  delta_y_squared *= delta_y_squared;

            bool isTrinagle = (long)((long)minimum + (long)midium) > Longest &&
                              (long)((long)midium + (long)Longest) > minimum &&
                              (long)((long)Longest + (long)minimum) > midium &&
                              (Longest > 0) &&
                              (midium > 0) &&
                              (minimum > 0);

            //(delta_radius_squared <= (delta_x_squared + delta_y_squared) && (delta_x_squared + delta_y_squared) <= delta_radiusSum_squared);
            if (isTrinagle)
            {
                if (Longest == midium && midium == minimum)
                {
                    ret = TriangleType.Equilateral;
                    //Equlized
                }
                else if (Longest == midium || minimum == midium)
                {
                    // base with 2 Equal value
                    ret = TriangleType.Isosceles;
                }
                else
                {
                    ret = TriangleType.Scalene;
                    // Normal 
                }
            }
            else
            {
                ret = TriangleType.Error;
                //Not Even Triangle
            }
            return ret;
        }


        public string ReverseWords(string s)
        {
            StringBuilder StrBuilderBuffer = null;
            if (s == null)
            {
                var argumentNullException = new ArgumentNullException("s");
                throw new FaultException<ArgumentNullException>(argumentNullException, "Value cannot be null.");
            }
            else
            {
                StrBuilderBuffer = new StringBuilder(s);
                int ptrEnd = 0;
                int ptrStart = 0;
                int ptrOffsetOfNewWord = 0;
                while (true)
                {


                    for (; ptrEnd < StrBuilderBuffer.Length && StrBuilderBuffer[ptrEnd] != ' '; ptrEnd++) ;
                    ptrOffsetOfNewWord = ptrEnd;
                    ptrEnd--;
                    for (; ptrEnd >= ptrStart; ptrStart++, ptrEnd--)
                    {
                        char swapCharacter = StrBuilderBuffer[ptrStart];
                        StrBuilderBuffer[ptrStart] = StrBuilderBuffer[ptrEnd];
                        StrBuilderBuffer[ptrEnd] = swapCharacter;
                    }
                    if (ptrEnd == StrBuilderBuffer.Length)
                    {
                        break;
                    }
                    else
                    {
                        ptrStart = ptrEnd = ptrOffsetOfNewWord + 1;
                    }
                }
            }
            return StrBuilderBuffer.ToString();
         
        }


        public long FibonacciNumber(long n)
        {
            if( n >= 93)
            {
                var argumentOutOfRangeException = new ArgumentOutOfRangeException("n");
                throw new FaultException<ArgumentOutOfRangeException>(argumentOutOfRangeException, "Result cannot be stored in 64 bit long");
            }
            long firstValue = 0;
            long secondValue = 1;
            long sum = n == 1 ? 1 : 0;

            if (n < 0)
            {
                secondValue = 1;
                firstValue = 0;
                for(long i=-1; i>=n;i--)
                {
                    checked
                    {
                        try
                        {
                            sum = secondValue - firstValue;
                            secondValue = firstValue;
                            firstValue = sum;
                        }
                        catch
                        {
                            var argumentOutOfRangeException = new ArgumentOutOfRangeException("n");
                            throw new FaultException<ArgumentOutOfRangeException>(argumentOutOfRangeException, "Result cannot be stored in 64 bit long");
                        }
                    }
                }
            }
            else
            {
               

                for (long i = 2; i <= n; i++)
                {
                    checked
                    {
                        try
                        {
                            sum = firstValue + secondValue;
                        }
                        catch
                        {
                            var argumentOutOfRangeException = new ArgumentOutOfRangeException("n");
                            throw new FaultException<ArgumentOutOfRangeException>(argumentOutOfRangeException, "Result cannot be stored in 64 bit long");
                        }
                    }
                    firstValue = secondValue;
                    secondValue = sum;
                }
            }
            return sum;

        }
    }
}
