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
using notes;

namespace xmlfile
{
    public class xml
    {
        public static DataRow [] xmlsearch(string s, string NomDuXml)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(NomDuXml);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            DataRow[] dr = dt.Select(s);
            return dr;
        }
        public static DataTable ouvrerxml(string name)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(name+".xml");
            DataTable dt = ds.Tables[0];
            return dt;
        }
        public static void registrer(string s,string pass, string age , string couleurprefe)
        {
            DataTable dt;
            dt = ouvrerxml("registration");
            DataRow dr = dt.NewRow();
            dr[0] = Chiffrer(s);
            dr[1] = Chiffrer(pass);
            dr[2] = Chiffrer(age);
            dr[3] = Chiffrer(couleurprefe);
            dr[4] = "0";
            dr[5] = "0";
            dr[6] = "0";
            dr[7] = "0";
            dr[8] = "0";
            dr[9] = "0";
            dr[10] = "0";
            dr[11] = "0";
            dr[12] = "0";
            dr[13] = "0";
            dr[14] = "0";
            dr[15] = "0";
            dr[16] = "0";
            dt.Rows.Add(dr);
            dt.WriteXml("registration.xml");
        }
        public static void notes(float not, int row)
        {
            int a;
            string s3, s4, s2 = Chiffrer(note.s);
            DataTable dt = ouvrerxml("registration");
            for (a = 0; a < dt.Rows.Count; a++)
            {
                s3 = dt.Rows[a][0].ToString();
                if (s2 == s3)
                {
                    DataSet dl1 = new DataSet();
                    dl1.ReadXml("registration.xml");
                    DataTable dt1 = dl1.Tables[0];
                    {
                        s4 = not.ToString();
                        if ((s2 == s3) && (s2 != "") && (s3 != ""))
                        {
                            dt1.Rows[a][row] = s4;
                            dl1.WriteXml("registration.xml");
                            break;
                        }
                    }
                }
            }
        }
        public static string DonnerScore()
        {
            string score = "";
            DataTable dt = ouvrerxml("registration");
            string s1 = Chiffrer(note.s),s2;// s contient le username
            for(int a =0; a < dt.Rows.Count; a++)
            {
                s2 = dt.Rows[a][0].ToString();
                if (s1 == s2)
                {
                    int somme = int.Parse(dt.Rows[a][4].ToString()) + int.Parse(dt.Rows[a][5].ToString()) + int.Parse(dt.Rows[a][6].ToString()) + int.Parse(dt.Rows[a][7].ToString()) + int.Parse(dt.Rows[a][8].ToString()) + int.Parse(dt.Rows[a][9].ToString()) + int.Parse(dt.Rows[a][10].ToString()) + int.Parse(dt.Rows[a][11].ToString())+ int.Parse(dt.Rows[a][12].ToString())+ int.Parse(dt.Rows[a][13].ToString())+ int.Parse(dt.Rows[a][14].ToString())+ int.Parse(dt.Rows[a][15].ToString())+ int.Parse(dt.Rows[a][16].ToString());
                    score = (somme).ToString();
                    break;
                }
            }return score;
        }
        private static DESCryptoServiceProvider GenerateKey()
        {
            DESCryptoServiceProvider desCrypto = new DESCryptoServiceProvider();
            byte[] k = { 0, 1, 2, 3, 4, 5, 6, 7 };
            desCrypto.Key = k;
            byte[] iv = { 1, 1, 1, 1, 1, 1, 1, 1 };
            desCrypto.IV = iv;
            return desCrypto;
        }
        public static string Chiffrer(string MotClair)
        {
            if (String.IsNullOrEmpty(MotClair))
                return "??????????";
            DESCryptoServiceProvider cryptoProvider = GenerateKey();
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream,
                cryptoProvider.CreateEncryptor(cryptoProvider.Key, cryptoProvider.IV), CryptoStreamMode.Write);
            StreamWriter writer = new StreamWriter(cryptoStream);
            writer.Write(MotClair);
            writer.Flush();
            cryptoStream.FlushFinalBlock();
            writer.Flush();
            return Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
        }
        public static string DeChiffrer(string MotChiffre)
        {
            try
            {
                if (String.IsNullOrEmpty(MotChiffre))
                    return "??????????";
                DESCryptoServiceProvider cryptoProvider = GenerateKey();
                MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(MotChiffre));
                CryptoStream cryptoStream = new CryptoStream(memoryStream,
                    cryptoProvider.CreateDecryptor(cryptoProvider.Key, cryptoProvider.IV), CryptoStreamMode.Read);
                StreamReader reader = new StreamReader(cryptoStream);
                return reader.ReadToEnd();
            }
            catch
            {
                return "??????????";
            }
        }
    }
}
