using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animals
{
    public class Dog : Animal, Isound
    {
        public Dog(int age,string name,Sex sex)
            :base(age,name,sex)
        {
            
        }
    
        public void AnimalSound()
        {
            Console.WriteLine("Barck ,Barck");
        }
    }
}
