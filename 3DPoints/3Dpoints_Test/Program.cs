using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _3DPoints;
namespace _3Dpoints_Test
{
    class Program
    {
        static void Main(string[] args)
        {

            Points3D point = new Points3D();
            point.x = 10;
            point.y = 23;
            point.z = 54;
            //Console.WriteLine(point.ToString());
            
            //Calculation of a distance bbetwaen P1 and P2

            Points3D point1 = new Points3D();
            point1.x = 23;
            point1.y = 0;
            point1.z = 0;

          //Console.WriteLine(Distanse.get_Distance(point1, point));

          Path path = new Path();

          for (int i = 0; i < 1; i++)
          {
              path.Points.Add(point1);
          }


           // PathStorage.SavePathList(path.Points);
            //Console.WriteLine("LOOK ON FILE");

             //string filepath = @"..\..\storage\pathstorage.dat";
             //PathStorage.loadePathList(filepath);
          //GenericList<string> str = new GenericList<string>(6);

          //str.addelement("element1");
          //str.addelement("Element2");
          //str.addelement("Element3");
          //str.addelement("Element3");
          //str.addelement("Element3");
         // Console.WriteLine("{0},{1},{2}", str[0].ToString(), str[1].ToString(), str[2].ToString());
         //string[] newlist=str.removeElement(1);

         //Console.WriteLine("{0},{1}", newlist[0].ToString(), newlist[1].ToString());
            //GenericList<string> str2=new GenericList<string>(7);
          //string[] str2 = str.insertElement(2, "Goshotypoto");

          //Console.WriteLine("{0}.{1},{2},{3}", str2[0], str2[1], str2[2], str2[3]);

          
        //    for (int i = 0; i < str2.Length; i++)
        //    {
        //        Console.WriteLine(str2[i]);
        //    }
          // str.clear();
     
         // str.findVaue("Ele");

          //Matrix<int> mt = new Matrix<int>(2, 2);


          Matrix<int> matr = new Matrix<int>(2,2);
          matr.setItem(0, 1, 1);
          matr.setItem(1, 0, 2);
          matr.setItem(1, 1, 3);
          matr.setItem(0, 0, 4);
          

                    Console.WriteLine("{0},{1}",matr.getItem(0,0),matr.getItem(0,1));
                    Console.WriteLine("{0},{1}",matr.getItem(1,0),matr.getItem(1,1));
			      Console.WriteLine("Min valueof the matrix is = {0}",matr.Max<int>().ToString());
                

                  Matrix<int> matr2 = new Matrix<int>(2, 2);
                  matr2.setItem(0, 1, 1);
                  matr2.setItem(1, 0, 2);
                  matr2.setItem(1, 1, 3);
                  matr2.setItem(0, 0, 4); 
            Console.WriteLine("Sum of matrix 1");
             Console.WriteLine("{0},{1}",matr.getItem(0,0),matr.getItem(0,1));
             Console.WriteLine("{0},{1}",matr.getItem(1,0),matr.getItem(1,1));

             Console.WriteLine("Sum of matrix 2");
             Console.WriteLine("{0},{1}",matr2.getItem(0,0),matr2.getItem(0,1));
             Console.WriteLine("{0},{1}",matr2.getItem(1,0),matr2.getItem(1,1));

             Matrix<int> matrix3 = new Matrix<int>(2, 2);
             matrix3 = matr * matr2;
             Console.WriteLine("Sum of matrix 3");
             Console.WriteLine("{0},{1}", matrix3.getItem(0, 0), matrix3.getItem(0, 1));
             Console.WriteLine("{0},{1}", matrix3.getItem(1, 0), matrix3.getItem(1, 1));


             Type type = typeof(_3DPoints.Path);
             object[] allAttributes = type.GetCustomAttributes(false);
             foreach (Custm_Atribut versionatribut in allAttributes)
             {
                 Console.WriteLine("Versioncontrol {0}.{1} ",
                     versionatribut.Major,versionatribut.Minor);
             }
           Console.ReadLine();
        }
    }
}
