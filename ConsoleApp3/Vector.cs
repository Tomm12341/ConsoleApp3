using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Vector
    {
        private readonly double _x;  
        private readonly double _y;

        public double X { get { return _x; } }
        public double Y { get { return _y;} }

        public Vector(double x, double y)
        {
            _x = x;
            _y = y;
        }
        public static Vector operator+(Vector a, Vector b) {
            Vector v= new Vector(a.X+b.X,a.Y+b.Y);
            return v;
        }

        public override string ToString()
        {
            return $"{X};{Y}";
        }

        public static Vector operator - (Vector effe)
        {
            Vector f = new Vector(effe.Y, effe.X);
            return f;
        }

        public static Vector operator -(Vector a, Vector b)
        {
            Vector emme = new Vector(a.X - b.X, a.Y - b.Y);
            return emme;
        }

        public static double operator *(Vector a, Vector b )
        {
            double risultato = a.X * a.Y + b.X * b.Y;
            return risultato;
        }

        public static Vector operator *(Vector a, double s)
        {
            return new Vector(a.X * s, a.Y * s);
        }


        public static Vector operator /(Vector a, double s)
        {
            return new Vector(a.X / s, a.Y / s);
        }


        public static  Vector Parse(string s)
        {
           var parts= s.Split(';');
            Vector sa = new Vector(int.Parse(parts[0]), int.Parse(parts[1]));

            return sa;
        }

        public static bool TryParse(string saa, out Vector veee)
        {
            try
            {
                veee = Vector.Parse(saa);
                return true;
            }
            catch
            {
                veee = null;
                return false;   
            }
        }

        public static bool operator !=(Vector v1, Vector v2)
        {
            if (!(v1.X == v2.X && v1.Y == v2.Y))
            {
                return true;
            }
            else
                return false;
        }
        public static bool operator ==(Vector v1, Vector v2)
        {
            if (v1.X == v2.X && v1.Y == v2.Y)
            {
                return true;
            }
            else
                return false;
        }

        public double Modulo(Vector v1)
        {
            double risultato= Math.Sqrt(Math.Pow(v1.X,2)+Math.Pow(v1.Y,2));

            return risultato;
        }

    }
}
