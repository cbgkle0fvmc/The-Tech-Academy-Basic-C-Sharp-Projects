using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod_SubmissionAssignment2
{
    public class mathOperations
    {
        public int MathOperation (int number)
        {
            return number + number;
        }

        public int MathOperation (decimal decimalNum)
        {
            decimal decValue = decimalNum + decimalNum;
            int decValueToInt = Convert.ToInt32 (decValue);
            return decValueToInt;
        }

        public int MathOperation (string stringToInt)
        {
            int IntNumber = Convert.ToInt32 (stringToInt);
            return IntNumber * IntNumber;
        }
    }
}
