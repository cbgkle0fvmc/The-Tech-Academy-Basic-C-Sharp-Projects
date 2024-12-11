using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace callingMethods_submissionAssignment
{
    public class integerOperations
    {
        //create constructor (assigned values upon creation)

        public int additionOperation(int number)
        {
            return number + 10;
        }
        public int multiplicationOperation(int number)
        {
            return number * 2;
        }
        public int divisionOperation(int number)
        {
            return number / 3;
        }
    }
}
