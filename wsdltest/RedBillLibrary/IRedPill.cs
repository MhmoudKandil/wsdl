using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace RedBillLibrary
{
    public enum TriangleType
    {
        Error = 0,

        Equilateral = 1,

        Isosceles = 2,

        Scalene = 3,
    }

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Namespace = "http://KnockKnock.readify.net")]
    public interface IRedPill
    {   
        [OperationContract]
        Guid WhatIsYourToken();
        [OperationContract]
        TriangleType WhatShapeIsThis(int a, int b, int c);
        [OperationContract]
        [FaultContract(typeof(ArgumentNullException))]
        string ReverseWords(string s);
        [OperationContract]
        [FaultContract(typeof(ArgumentOutOfRangeException))]
        long FibonacciNumber(long n);

        // TODO: Add your service operations here
    }
}
