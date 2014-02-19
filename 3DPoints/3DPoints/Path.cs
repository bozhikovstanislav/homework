using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3DPoints
{
    [Custm_Atribut(2, 88)]
   public class Path
    {
        private List<Points3D> points=new List<Points3D>();

        public Path()
        {
        }
        public Path(List<Points3D> points)
        {
            this.points = points;
        }
        public List<Points3D> Points
        {
            get { return points; }
            set { points = value; }
        }
    }
}
