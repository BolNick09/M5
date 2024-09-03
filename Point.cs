using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_reload
{
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }
        public static Point operator ++(Point p)
        {
            p.x++;
            p.y++;
            return p;
        }
        public static Point operator --(Point p)
        {
            p.x--;
            p.y--;
            return p;
        }
        public static Point operator -(Point p)
        {
            return new Point { x = -p.x, y = -p.y };
        }
        public override string ToString()
        {
            return $"Point: X={x}, Y= {y}";
        }
        public override bool Equals(object? obj)
        {
            return this.ToString() == obj.ToString();
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public static bool operator ==(Point p1, Point p2)
        {
            return p1.Equals(p2);
        }
        public static bool operator !=(Point p1, Point p2)
        {
            return !(p1 == p2);
        }
        public static bool operator > (Point p1, Point p2)
        {
            return Math.Sqrt(p1.x * p1.x + p1.y * p1.y) > Math.Sqrt(p2.x * p2.x + p2.y * p2.y);
        }
        public static bool operator < (Point p1, Point p2)
        {
            return Math.Sqrt(p1.x * p1.x + p1.y * p1.y) < Math.Sqrt(p2.x * p2.x + p2.y * p2.y);
        }

    }
}
