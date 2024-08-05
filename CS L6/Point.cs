using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_L6
{
    internal class Point
    {
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;

        public static Point operator - (Point point) 
        {           
            return new Point { X = -point.X, Y = -point.Y };            
        }

        public static Point operator ++ (Point point)
        {
            point.X++;
            point.Y++;
            return point;
        }
        public static Point operator -- (Point point)
        {
            point.X--;
            point.Y--;
            return point;
        }

        public static Point operator +(Point p1, Point p2)  
        {
            return new Point
            {
                X = p1.X + p2.X,
                Y = p1.Y + p2.Y
            };
        }
        public static Point operator -(Point p1, Point p2)  
        {
            return new Point
            {
                X = p1.X - p2.X,
                Y = p1.Y - p2.Y
            };
        }

        public static Point operator * (Point p1, int n)
        {
            return new Point  { X = p1.X * n,  Y = p1.Y *n };
        }
        public static Point operator * (int m, Point p1)
        {
            return p1* m;
        }

        public static Point operator / (Point p1, int n)
        {
            return new Point { X = p1.X / n, Y = p1.Y / n };
        }


        public override bool Equals(Object obj)
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
            return p1.Equals(p2);
        }


        public static bool operator true( Point p)
        {
            if ( p.X == 0 && p.Y ==0) return true;
            return false;
        }
        public static bool operator false( Point p)
        {
            if ( p.X == 0 && p.Y ==0) return false;
            return true;
        }


        public override string ToString()
        {
            return $"Point: X= {X}, Y= {Y}";
        }

    }
}
