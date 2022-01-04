using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class level2 : Form
    {
        DataSet ds = new DataSet();
        DataTable dt;
        int i, j2 = 0, k = 0, n;
        int count=0;
        Random r = new Random();
        public level2()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void back_Click(object sender, EventArgs e)
        { this.Close();
           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

      public void level2_Load(object sender, EventArgs e)
        {
            ds.ReadXml(@"C:\Users\User\Desktop\WindowsFormsApp13\WindowsFormsApp13\bin\Debug\level2.xml");
            dt = ds.Tables[0];
            textBox2.Focus();
            question.Text = "question " + (k+ 1) + ":";
            i = r.Next(1,5);
            DataRow dr = dt.Rows[i];
            label1.Text = dr["question"].ToString();
            if (i < 20)
            {
                textBox3.Hide();
                textBox4.Hide();
            }
            else
            {
                textBox3.Show();
                textBox4.Show();
            }
            button2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            metode1();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (i < 21)
                {if (button1.Visible == true)
                        metode1();
                    else
                        methode2();

                }
                    

                else

                    textBox3.Focus();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox4.Focus();

        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                if (button1.Visible == true)
                    metode1();
                else
                    methode2();
                    }
        }

        private void metode1() { 
            n = i;
           
            DataRow dr = dt.Rows[i];
            if (i < 21)
                if (textBox2.Text.Length != 0)
                {
                    timer1.Stop();
                    if (textBox2.Text.ToLower() == dr["repone1"].ToString().ToLower())
                    {
                        MessageBox.Show("bravoo");

                        j2++;
                        k++;
                        button1.Hide();
                    }
                    else
                    {
                        MessageBox.Show("faux  la reponce correct est:"+ dr["repone1"].ToString());

                        k++;
                        button1.Hide();
                    }
                }
                else
                    MessageBox.Show("pardont calculer l'exercice");
            else
            {
                if (textBox2.Text.Length != 0 && textBox3.Text.Length != 0 && textBox4.Text.Length != 0)

                {
                    timer1.Stop();
                    if ((textBox2.Text.ToString().Trim() == dr["repone1"].ToString()) && (textBox3.Text.ToString().Trim() == dr["reponce2"].ToString()) && (textBox4.Text.ToString().Trim() == dr["correction1"].ToString()))
                    {
                        MessageBox.Show("bravoo");

                        j2++;
                        k++;
                        button1.Hide();
                    }
                    else
                    {
                        MessageBox.Show("faux la reponce correct est " + dr["repone1"].ToString() + "  " + dr["reponce2"].ToString() + "  " + dr["correction1"].ToString());
                        k++;
                        button1.Hide();
                    }
                }
                else
                    MessageBox.Show("pardont calculer l'exercice");
            }
            
            
            if (k < 10)
            {
                if (textBox2.Text.Length != 0)
                    button2.Show();
              
            }
            else
            { 
                MessageBox.Show("cette niveau est fini avec " + j2 + "/10 la note");
                this.Close();
               

            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            methode3();
        }
        private void methode3()
        {
            timer1.Start();
            count++;
            label2.Text = count.ToString();
            if (count == 15)
            {
                if (k == 9)
                {
                    timer1.Stop();
                    MessageBox.Show("cette niveau est fini avec " + j2 + "/10 la note");
                    this.Close();
                   
                }
                else
                {

                    timer1.Stop();
                    MessageBox.Show("pardont la time est fini");
                  
                    k++;
                    methode2();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.Rows[i];
            j2++;
            k++;
            if (i < 21)
            {
                MessageBox.Show("la reponce correct est: "+ dr["repone1"].ToString());
            }
            else
                MessageBox.Show(" la reponce correct est " + dr["repone1"].ToString() + "  " + dr["reponce2"].ToString() + "  " + dr["correction1"].ToString());
            
            button3.Hide();
            if (k == 10)
            {
                timer1.Stop();
                MessageBox.Show("cette niveau est fini avec " + j2 + "/10 la note");
                this.Close();

            }
            else
                methode2();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            methode2();
        }
        private void methode2() {
          
            question.Text = "question " + (k + 1) + ":";
            textBox2.Clear();
            textBox3.Clear();
            count = 0;
            timer1.Start();
            methode3();
            do
            {
                if (k < 2)
                    i = r.Next(1, 5);
                else
                {
                    if ((k >= 2) && (k < 4))
                        i = r.Next(6, 10);
                    else
                    {
                        if ((k >= 4) && (k < 6))
                            i = r.Next(11, 20);
                        else
                            if ((k >= 6) && (k < 8))
                            i = r.Next(21, 25);
                        else
                            i = r.Next(26, 30);

                    }
                }
            } while (n == i);
            DataRow dr = dt.Rows[i];
            textBox4.Clear();
            textBox3.Clear();
            textBox2.Clear();
            label1.Text = dr["question"].ToString();
            if (i < 20)
            {
                textBox3.Hide();
                textBox4.Hide();
            }
            else
            {
                textBox3.Show();
                textBox4.Show();
            }
            button2.Hide();
            button1.Show();
            textBox2.Focus();
        }
    }
}
