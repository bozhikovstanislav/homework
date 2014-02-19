using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrincipalOOP1
{
    public class Disciplin : IComment
    {
        private int numberOflectures;

        public int NumberOflectures
        {
            get { return numberOflectures; }
            set { numberOflectures = value; }
        }
        private int numberOfexersice;

        public int NumberOfexersice
        {
            get { return numberOfexersice; }
            set { numberOfexersice = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
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
