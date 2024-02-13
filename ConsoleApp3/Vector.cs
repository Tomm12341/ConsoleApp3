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
        private readonly float _x;  
        private readonly float _y;

        public float X { get { return _x; } }
        public float Y { get { return _y;} }

        public Vector(float x, float y)
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

        public static double operator *(Vector a, Vector b)
        {
            double risultato = a * b * Math.Cos(35);
            return risultato;
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

    }
}
