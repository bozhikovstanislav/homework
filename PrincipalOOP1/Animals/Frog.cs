using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animals
{
    public class Frog : Animal, Isound
    {
        public Frog(int age,string name,Sex sex)
            :base(age,name,sex)
        {
            
        }
    
        public void AnimalSound()
        {
            Console.WriteLine("Quack Quack");
        }
    }
}
