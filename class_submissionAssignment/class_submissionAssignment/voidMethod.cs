using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_submissionAssignment
{
    internal class voidMethod
    {
        public int value {  get; set; }
        public void mathOp (int number)
        {
            value = number / 2;
        }
        public string stringValue(string stringInput, out int outputInt)
        {
            outputInt = stringInput.Length;
            string stringOp = "Your string is " + outputInt + "characters.";
            return stringOp;
        }
    }
}
