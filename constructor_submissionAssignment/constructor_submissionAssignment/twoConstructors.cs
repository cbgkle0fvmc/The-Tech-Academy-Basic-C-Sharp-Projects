using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using constructor_submissionAssignment;
using System.Xml.Linq;

namespace constructor_submissionAssignment
{
    public class twoConstructors
    {

        public twoConstructors(string fname, string lname) : this(fname, fname + lname)
        {

        }
        public string FName { get; set; }
        public string Lname { get; set; }
        public string username { get; set; }
    }
    
    

    
}