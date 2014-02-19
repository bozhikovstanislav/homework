using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrincipalOOP1
{
    public class Student : People, IComment
    {
        private int classNumber;

        public int ClassNumber
        {
            get { return classNumber; }
            set { classNumber = value; }
        }

        public string Comment
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
