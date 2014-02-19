using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrincipalOOP1
{
    public class Classes : IComment
    {
        private string identifire;

        public string Identifire
        {
            get { return identifire; }
            set { identifire = value; }
        }
        private List<Teachers> teacher;

        public List<Teachers> Teacher
        {
            get { return teacher; }
            set { teacher = value; }
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
