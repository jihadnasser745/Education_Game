using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13
{
    public class Fractions
    {
        int n, d;
        public int N { get { return n; } }
        public int D { get { return d; } }
        public Fractions()//construction par default
        {
            n = 0;
            d = 1;

        }
        public Fractions(int num)
        {
            n = num;
            d = 1;

        }
        public Fractions(int num, int den)
        {
            n = num; d = den;
            reduire();
        }
        public Fractions(Fractions c)
        {
            n= c.n; d= c.d;

        }
        private static int pgcd(int a, int b)
        {
            while (a != b)
                if (a > b) a = a - b;
                else b = b - a;
            return a;
        }
        private static int ppcm(int a, int b)
        {
            return a * b / pgcd(a, b);

        }
        private void reduire()
        {
            int p = pgcd(n, d);
            n /= p; d /= p;
        }
        public override string ToString()
        {

            return n.ToString() + "/" + d.ToString();

        }
        public static Fractions parse(string fs)
        {
            int num, den;
            string[] s = fs.Split('/');
            num = int.Parse(s[0].Trim());
            den = int.Parse(s[1].Trim());
            return new Fractions(num, den);

        }
        public static Fractions operator +(Fractions l, Fractions r)
        {
            int p = ppcm(l.d, r.d);
            return new Fractions(l.n * p / l.d + r.n * p / r.d, p);

        }
        public static Fractions operator -(Fractions l, Fractions r)
        {
            int p = ppcm(l.d, r.d);
            return new Fractions(l.n * p / l.d - r.n * p / r.d, p);




        }
        public static Fractions operator *(Fractions l, Fractions r)
        {
            return new Fractions(l.n * r.n, l.d * r.d);
        }
        public static Fractions operator /(Fractions l, Fractions r)
        {
            return new Fractions(l.n * r.d, l.d * r.n);
        }
        public static Fractions operator !(Fractions l)
        {
            return new Fractions(l.d, l.n);
        }
        public static bool operator ==(Fractions l, Fractions r)
        {
            l.reduire();r.reduire();
            return ((l.n == r.n) && (l.d == r.d));

        }
        public static bool operator !=(Fractions l, Fractions r)
        {
            l.reduire(); r.reduire();
            return ((l.n != r.n) || (l.d != r.d));

        }
        public static implicit operator Fractions(int i)
        {
            return new Fractions(i);
        }
        public static explicit operator float(Fractions f)
        {
            return f.n / (float)f.d;

        }

        public static explicit operator double(Fractions f)
        {
            return f.n / (double)f.d;

        }

    }
}
