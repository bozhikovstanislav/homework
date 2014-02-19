using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animals
{
    public class Kitten : Cat, Isound
    {
        public Kitten(int age,string name)
            :base(age,name)
        {
            this.Sex = Sex.fmale;
        }
    
        public void AnimalSound()
        {
            Console.WriteLine("Kitten sound=Miau,Miau");
        }
    }
}
