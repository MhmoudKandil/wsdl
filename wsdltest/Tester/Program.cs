using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tester
{
    class Program
    {
        public static void verifyFibonacciNumber()
        {
            ServiceReference1.RedPillClient readifyServiceClient = new ServiceReference1.RedPillClient();
            ServiceReference2.RedPillClient myServiceClient = new ServiceReference2.RedPillClient();

            for (int i = -10; i <= 10; i++)
            {
                long r1 = readifyServiceClient.FibonacciNumber(i);
                long r2 = myServiceClient.FibonacciNumber(i);
                Console.WriteLine("{0} {1} {2}",r1 == r2,r1.ToString(), r2.ToString());
            }
        }
        public static void verifyWhatShapeIsThis()
        {
            ServiceReference1.RedPillClient r = new ServiceReference1.RedPillClient();
            ServiceReference2.RedPillClient s = new ServiceReference2.RedPillClient();
            ServiceReference1.TriangleType ret;
            ServiceReference2.TriangleType ret2;
            for (int i = -1; i <= 2; i++)    
            for(int j=-1; j<=2; j++)
                    for (int k = -1; k <= 2; k++)
                    {
                        ret = r.WhatShapeIsThis(i, j, k);
                        ret2 = s.WhatShapeIsThis(i, j, k);
                        Console.WriteLine("{0} {1} {2}",(int)ret == (int)ret2, ret, ret2);
                    }
            ret = r.WhatShapeIsThis(int.MaxValue, int.MaxValue, int.MaxValue);
            ret2 = s.WhatShapeIsThis(int.MaxValue, int.MaxValue, int.MaxValue);
            Console.WriteLine("{0} {1} {2}", ret, ret2, (int)ret == (int)ret2);

        }     
        public static void verifyReverseWords()
        {
            ServiceReference1.RedPillClient redifyServiceClient = new ServiceReference1.RedPillClient();
            ServiceReference2.RedPillClient myServiceClinet = new ServiceReference2.RedPillClient();
            
            string[] Statments = 
            {
                "test 2word",
                " muiltiple worlds ",
                "Hello World ",
                "  many   words   with   multiple   spaces   and   special  chracters :D :D :D",
                "hello helloo hellooo helloooo hellooooo hellooooo helloooo",
                "POIUYTREW ASDFGHJ MNBVCX IJUYTR  !@#$% #$%^ $%^& JHGF  FVVFVFV",
                "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww"
            };

            foreach(string st in Statments)
            {
                string st1 = redifyServiceClient.ReverseWords(st);
                string st2 = myServiceClinet.ReverseWords(st);
                Console.WriteLine("{0} {1} {2}",st1 == st2, st1, st2);
            }

        }
        static void Main(string[] args)
        {
            verifyFibonacciNumber();
            verifyReverseWords();
            verifyWhatShapeIsThis();
        }
    }
}
