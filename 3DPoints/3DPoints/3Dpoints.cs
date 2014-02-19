using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _3DPoints
{

    public struct Points3D
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
        static readonly Points3D zero = new Points3D(0, 0, 0);

        public static Points3D Zero
        {
            get { return Points3D.zero; }
        }



        public Points3D(int x, int y, int z)
            : this()
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {

            return  "Point "+ "\n \n" + "Coordinate x = " + x + "\n" + "Coordinate y = " + y + "\n" + "Coordinate Z = " + z + "\n"+
                "\n_________________________________________";
        }
    }
}

