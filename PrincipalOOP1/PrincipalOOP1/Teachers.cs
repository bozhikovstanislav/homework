using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrincipalOOP1
{
    public class Teachers : People, IComment
    {
        private List<Disciplin> disiplin;

        public List<Disciplin> Disiplin
        {
            get { return disiplin; }
            set { disiplin = value; }
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
