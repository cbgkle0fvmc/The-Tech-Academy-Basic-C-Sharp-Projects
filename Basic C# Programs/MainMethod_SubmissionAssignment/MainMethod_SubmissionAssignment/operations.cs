using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod_SubmissionAssignment
{
    public class operations
    {
        public int additionOperation (int number)
        {
            return number + number;
        }

    }

    public class decimalOperation
    {
        public decimal decimalOp(decimal decimalNumber)
        {
            return Convert.ToInt32(decimalNumber + 15);
        }
    }

    public class stringToNum
    {
        public int stringToNumber (int stringNumber)
        {
            return (stringNumber + 5);
        }
    }
}
