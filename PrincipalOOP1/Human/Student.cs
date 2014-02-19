using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Human
{
    public class Student : Human
    {
        private int grade;
        public Student(int grade)
        {
            this.grade = grade;
        }
        public Student()
            :base()
        {

        }
        public Student(string firstname,string lastname,int grade)
            :base(firstname,lastname)
        {
            this.grade = grade;
        } 
        
        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        public override string ToString()
        {
            return this.FirstName;
        }
    }
}
