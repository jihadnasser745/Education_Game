using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Media;

namespace count
{
    public class fonctions
    {
        public static int[] randomdiff(int TailleDuTableau,int MaxValeure)
        {
            int[] t = new int[TailleDuTableau];
            Random r = new Random();
            int count = 0;
            while (count != TailleDuTableau)
            {
                int a = 0;
                int x = r.Next(1, MaxValeure);
                for (int i = 0; i < count; i++)
                {
                    if (t[i] == x) a = 1;
                }
                if (a == 0)
                {
                    t[count] = x;
                    count++;
                }
            }
            return t;
        }
        public static int v = 0, w;
        public static string remplirpic(string s)
        {
            int[] t1 = new int[10];
            t1 = randomdiff(10,11);
            
            w = t1[v];
            string s1 = w.ToString() + ".jpeg",location;
            location = s + s1;
            return location;
        }
        public static string remplirpics(string s)
        {
            
            string location = remplirpic(s);
            v++;
            return location;
        }
    }
}
