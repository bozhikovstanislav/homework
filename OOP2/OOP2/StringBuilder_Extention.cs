using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP2
{
   public static class StringBuilder_Extention
    {
       public static StringBuilder Substring(this StringBuilder sb,int index,int lenght)
       {
           try
           {
               
               StringBuilder newsb = new StringBuilder(lenght);
               string strsb = sb.ToString();
               List<string> newstr2 = new List<string>();
               string[] separator = new string[] { ",", ".", "!", "\'", " " };
               string[] word = strsb.Split(separator, StringSplitOptions.RemoveEmptyEntries);

             

               for (int i = index; i < lenght+index; i++)
               {
                   newstr2.Add(word[i]);

               }
               for (int i = 0; i < newstr2.Count; i++)
               {
                   newsb.Append(newstr2[i].ToString() + " ");
               }
               return newsb;
           }
           catch (ApplicationException e)
           {
               throw new ApplicationException(e.Message);
           }
          
       }
    }
}
