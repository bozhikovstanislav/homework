using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _3DPoints
{
   public static class Distanse
    {

     

       public static double get_Distance(Points3D poit1, Points3D Point2)
       {
         
           double distance = Math.Sqrt(Math.Pow((poit1.x - Point2.x),2)  + Math.Pow((poit1.y - Point2.y),2) + Math.Pow((poit1.z - Point2.z),2));
           //double distance = Math.Sqrt(5.7);
           
           return Math.Round(distance,3);
       }

    }
}
