using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Operators_reload
{
    public class MyVector
    {
        public int x { get; set; }
        public int y { get; set; }

        public MyVector() { }
        public MyVector(Point begin, Point end)
        {
            x = end.x - begin.x;
            y = end.y - begin.y;
        }
        public static MyVector operator +(MyVector v1, MyVector v2)
        {
            return new MyVector
            {
                x = v1.x + v2.x,
                y = v1.y + v2.y
            };
        }
    }
}
