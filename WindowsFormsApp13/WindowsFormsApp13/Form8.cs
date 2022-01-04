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
    public partial class level5 : Form
    {
        Random r = new Random();
        int i=0, j5 = 0, k = 0, n1, d1, n2, d2,count;

  

        Fractions f1, f2, f3;

       

        public level5()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox3.Focus();

        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (button2.Visible == true)
                    methode1();
                else
                    methode2();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            methode4();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            j5++;
            k++;

            if (k == 10)
            {
                timer1.Stop();
                MessageBox.Show("cette niveau est fini avec " + j5 + "/10 la note");
                this.Close();
            }
            else
                methode2();

            }

        private void methode4()
        {
            timer1.Start();
            count++;
            label8.Text = count.ToString();
            if (count == 30)
            {
                if (k == 9)
                {
                    timer1.Stop();
                    MessageBox.Show("cette niveau est fini avec " + j5 + "/10 la note");
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

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {if (i< 8)
                {
                    if (button2.Visible == true)
                        methode1();
                    else
                        methode2();
                }
                else
                    textBox2.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {


            methode1();
        }
        public void methode1()
            
        {
            button3.Show();
            if (textBox1.Text.Length != 0)
            {
                timer1.Stop();
                if (k < 8)
                {
                    if (k < 2)
                    {
                        f3 = f1 + f2;

                        if (textBox1.Text.ToString().Trim() == f3.ToString())
                        {
                            button2.Hide();
                            MessageBox.Show("bravo");

                            j5++;
                            k++;

                        }
                        else
                        {

                            MessageBox.Show("faux la reponce correct est  " + f3);
                            button2.Hide();
                            k++;
                        }
                    }
                    else
                    {
                        if ((k >= 2) && (k < 4))
                        {
                            f3 = f1 - f2;
                            if (textBox1.Text.ToString().Trim() == f3.ToString())
                            {
                                button2.Hide();
                                MessageBox.Show("bravo");

                                j5++;
                                k++;

                            }
                            else
                            {

                                MessageBox.Show("faux la reponce correct est  " + f3);
                                button2.Hide();
                                k++;
                            }

                        }
                        else
                        {if ((k >= 4) &&( k < 6))
                                {

                                f3 = f1 * f2;

                                if (textBox1.Text.ToString().Trim() == f3.ToString())
                                {
                                    button2.Hide();
                                    MessageBox.Show("bravo");

                                    j5++;
                                    k++;

                                }
                                else
                                {

                                    MessageBox.Show("faux la reponce correct est  " + f3);
                                    button2.Hide();
                                    k++;
                                }
                            }else
                                if ((k >= 6) && (k < 8))
                            {
                                f3 = f1 / f2;
                                if (textBox1.Text.ToString().Trim() == f3.ToString())
                                {
                                    button2.Hide();
                                    MessageBox.Show("bravo");

                                    j5++;
                                    k++;

                                }
                                else
                                {

                                    MessageBox.Show("faux la reponce correct est  " + f3);
                                    button2.Hide();
                                    k++;
                                }
                            }
                        }
                    }
                }


                else
                {
                    if ((textBox1.Text.Length != 0) && (textBox2.Text.Length != 0) && (textBox3.Text.Length != 0))
                    {
                        timer1.Stop();
                        if (n1 == 1)
                            if ((textBox1.Text.Trim() == "12") && (textBox2.Text.Trim() == "15") && (textBox3.Text.Trim() == "43"))
                            {
                                MessageBox.Show("bravo");
                                j5++; k++; button2.Hide();
                            }
                            else
                            {
                                k++;
                                MessageBox.Show("faux la reponce correct est 12:15:43");
                            }
                        if (n1 == 2)
                            if ((textBox1.Text.Trim() == "10") && (textBox2.Text.Trim() == "10") && (textBox3.Text.Trim() == "30"))
                            {
                                j5++; k++; MessageBox.Show("bravo"); button2.Hide();
                            }
                            else
                            {
                                k++;
                                MessageBox.Show("faux la reponce correct est 10:10:30");
                            }
                        if (n1 == 3)
                            if ((textBox1.Text.Trim() == "6") && (textBox2.Text.Trim() == "0") && (textBox3.Text.Trim() == "42"))
                            {
                                j5++; k++; MessageBox.Show("bravo"); button2.Hide();
                            }
                            else
                            {
                                k++;
                                MessageBox.Show("faux la reponce correct est 6:0:42");
                            }
                        if (n1 == 4)
                            if ((textBox1.Text.Trim() == "10") && (textBox2.Text.Trim() == "10") && (textBox3.Text.Trim() == "26"))
                            {
                                j5++; k++; MessageBox.Show("bravo"); button2.Hide();
                            }
                            else
                            {
                                k++;
                                MessageBox.Show("faux la reponce correct est 6:0:42");
                            }
                    }
                    else
                    {
                        MessageBox.Show("pardon calculer l'exercice");
                        button3.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("pardon calculer l'exercice");
                button3.Hide();


            }
            string s = textBox1.Text.ToString();

            if (k < 10)
            {
                if (s.Length != 0)
                    button3.Show();
            }
            else
            {
                MessageBox.Show("cette niveau est fini avec " + j5 + "/10 la notes de cette niveau ");
                this.Close();
               
            }
        }
            private void button3_Click(object sender, EventArgs e)
        {
            methode2();
        }

        private void methode2()
        {
            count = 0;
            timer1.Start();
            methode4();
            i++;
            label1.Text = "question " + (k + 1) + ":";
            button2.Show();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            if (k < 2) 
                { n1 = r.Next(1, 10);
                    n2 = r.Next(1, 10);
                    d1 = r.Next(1, 10);
                    d2 = r.Next(1, 10);
                    f1 = new Fractions(n1, d1);
                    f2 = new Fractions(n2, d2);
                    label3.Text = (f1 + "+" + f2).ToString(); }
            else
            {
                    if ((k >= 2) && (k < 4))
                    {
                        n1 = r.Next(5, 10);
                        n2 = r.Next(1, 5);
                        d1 = r.Next(1, 5);
                        d2 = r.Next(5, 10);
                        f1 = new Fractions(n1, d1);
                        f2 = new Fractions(n2, d2);
                        label3.Text = (f1 + "-" + f2).ToString();
                    }
                    else
                    {
                        if ((k >= 4) && (k < 6))
                        {
                            n1 = r.Next(1, 10);
                        n2 = r.Next(1, 10);
                            d1 = r.Next(1, 10);
                            d2 = r.Next(1, 10);
                            f1 = new Fractions(n1, d1);
                            f2 = new Fractions(n2, d2);
                            label3.Text = (f1 + "*" + f2).ToString();
                        }

                        else
                        {
                        if ((k >= 6) && (k < 8))
                        {
                            n1 = r.Next(1, 10);
                            n2 = r.Next(1, 10);
                            d1 = r.Next(1, 10);
                            d2 = r.Next(1, 10);
                            f1 = new Fractions(n1, d1);
                            f2 = new Fractions(n2, d2);
                            label3.Text = (f1 + "/" + f2).ToString();
                        }
                        else {
                            label7.Hide();
                            label3.Text = "quelle l'heure?";
                            pictureBox1.Show();
                            textBox2.Show();
                            textBox3.Show();
                            label4.Show();
                            label5.Show();
                            label6.Show();
                            if( (k>=8)&&(k < 9)) {
                                n1 = r.Next(1, 2);
                                string s = n1.ToString() + ".jpg";
                                pictureBox1.ImageLocation = (@"C:\Users\User\Desktop\WindowsFormsApp13\WindowsFormsApp13\bin\Debug\" + s);
                            }
                            else {
                                n1 = r.Next(3,4);
                                string s = n1.ToString() + ".jpg";
                                pictureBox1.ImageLocation = (@"C:\Users\User\Desktop\WindowsFormsApp13\WindowsFormsApp13\bin\Debug\" + s);
                            }
                                
                        }
                           

                            
                                

                        }
                    }
                } 
         


           
            
            button3.Hide();
            textBox1.Focus();
        }











        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void level5_Load(object sender, EventArgs e)
        {
            label1.Text = "question " + (k + 1) + ":";
            n1 = r.Next(1, 10);
            n2 = r.Next(1, 10);
            d1 = r.Next(1, 10);
            d2 = r.Next(1, 10);
            f1 = new Fractions(n1, d1);
            f2 = new Fractions(n2, d2);
            label3.Text = (f1 + "+" + f2).ToString();
            textBox1.Focus();
            pictureBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Text = "pardont la reponce est sous la forme a/b(forme irreductible)";
        }
    }
}
