using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Text;


namespace Challenge
{
    public enum TriangleType
    {
        Error = 0,

        Equilateral = 1,

        Isosceles = 2,

        Scalene = 3,
    }
    /// <summary>
    /// Summary description for Chanllenges
    /// </summary>
    [WebService(Namespace = "http://KnockKnock.readify.net")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
 
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Chanllenges : System.Web.Services.WebService
    {
        [WebMethod]
        public Guid WhatIsYourToken()
        {
          Guid g;
          g = new Guid("36db9949-ac29-4b0e-90ee-1d817e6e6944");
          return g;
        }
       // [WebMethod]
        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            TriangleType ret;

            int Longest = Math.Max(a,Math.Min(b,c));
            int minimum = Math.Min(a,Math.Min(b,c));
            int midium = (int)((long)(a+b+c) - Longest + minimum);

            int circle1_x = 0;
            int circle1_y = 0;
            int circle1_r = minimum;

            int circle2_x = Longest;
            int circle2_y = 0;
            int circle2_r = minimum;

            long delta_radius_squared =  (circle1_r-circle2_r);
            delta_radius_squared *= delta_radius_squared;

            long delta_radiusSum_squared = (circle1_r+circle2_r);
            delta_radiusSum_squared *= delta_radiusSum_squared;

            long delta_x_squared = circle1_x-circle2_x;
            delta_x_squared*=delta_x_squared;

            long delta_y_squared = circle1_y-circle2_y;
            delta_y_squared*=delta_y_squared;

            bool isTrinagle = (delta_radius_squared <= (delta_x_squared+delta_y_squared) && (delta_x_squared+delta_y_squared) <= delta_radiusSum_squared);
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
     //   [WebMethod]
        public string ReverseWords(string s)
        {
            StringBuilder StrBuilderBuffer = new StringBuilder(s);
            for (int i = 0,j=StrBuilderBuffer.Length-1; i<j; i++,j--)
            {
                char chSwapChar = StrBuilderBuffer[i];
                StrBuilderBuffer[i] = StrBuilderBuffer[j];
                StrBuilderBuffer[j] = chSwapChar;

            }

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
                    StrBuilderBuffer[ptrStart] =  StrBuilderBuffer[ptrEnd];
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
            return StrBuilderBuffer.ToString();
          
        }

        string Sum(string L1, string L2)
        {
            if (L2.Length < L1.Length)
            {
                string L3 = L2;
                L2 = L1;
                L1 = L3;
            }
            StringBuilder Result = new StringBuilder(L2);
            string strResult = "";

            int Carry = 0;
            int k = 0;
            for (int i = L1.Length - 1, j = L2.Length - 1; i >= 0; i--, j--)
            {
                Result[j] = (char)((((int)L1[i] - 48) + ((int)L2[j] - 48) + Carry) + 48);
                Carry = ((L1[i] - 48) + (L2[j] - 48) + Carry) / 10;
                Result[j] = (char)(((Result[j] - 48) % 10) + 48);
                k = j;
            }
           for (int i = k - 1; i >= 0; i--)
            {
                Result[i] = (char)(((L2[i] - 48) + Carry) + 48);
                Carry = (Result[i] - 48) / 10;
                Result[i] = (char)(((Result[i] - 48) % 10) + 48);
            }
           if (Carry == 1)
           {
               strResult = "1" + Result.ToString();
           }
           else
           {
               strResult = Result.ToString();
           }
            return strResult;
            
        }

     //   [WebMethod]
        public string FibonacciNumber(long n)
        {

            string  firstValue    = "0";
            string  secondValue   = "1";
            string  strsum        = "0";
            for (long i = 2; i <= n; i++)
            {
                strsum = Sum(firstValue, secondValue);
                //Global.tblIndexToFibValue[i] = sum.ToString();
                firstValue = secondValue;
                secondValue = strsum ;
            }
            //Global.iMaxFibIndex = n > Global.iMaxFibIndex ? n : Global.iMaxFibIndex;
            return strsum.ToString();

        }
    }
}
