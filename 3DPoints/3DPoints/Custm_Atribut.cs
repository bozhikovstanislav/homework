using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3DPoints
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum 
        | AttributeTargets.Interface|AttributeTargets.Method,AllowMultiple = true)]
   public  class Custm_Atribut :System.Attribute
    {
        private int major;
        private int minor;
        private string version;

       
       public Custm_Atribut(int maj,int min)
       {
           this.minor = min;
           this.major = maj;
       }
         public int Major
        {
            get { return major; }
            set { major = value; }
        }
        public int Minor
        {
            get { return minor; }
            set { minor = value; }
        }
       public string Version
        {
            get { return version; }
            set
            {
                value = String.Format("{0}.{1}", minor, minor);
                version = value;
            }
        }
    }
}
