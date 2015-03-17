using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wsdltest
{
    class Program
    {
        static void Main(string[] args)
        {
            RedPillO.RedPillClient s = new RedPillO.RedPillClient();
            //RedPillS.RedPillClient s = new RedPillS.RedPillClient();

            Console.WriteLine(s.WhatIsYourToken());
            s.Close();
            
           
        }
    }
}
