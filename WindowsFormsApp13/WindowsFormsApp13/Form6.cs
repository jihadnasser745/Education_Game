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
    public partial class level3 : Form
    {
        DataSet ds = new DataSet();
        DataTable dt;
        int i, j3 = 0, k = 0,n;
        Random r = new Random();
        int count;

        public level3()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            methode3();
        }
        private void methode3() { 
            this.Close();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();

            label6.Show();
            label7.Show();
            label8.Show();
            label9.Show();
            timer1.Stop();
            DataRow dr = dt.Rows[i];
        
            if (button2.Text == dr["correction"].ToString())
            {
                MessageBox.Show("bravooo");
                j3++;
                
            }
            else
            {
                MessageBox.Show("faux  la reponce correct est: " + dr["correction"].ToString());
                

            }k++;
            n = i;
           
            if (k < 10)
                button6.Show();

            else
            {
                MessageBox.Show("cette niveau est fini avec " + j3 + "/10 la ");
                this.Close();
              
            }
        }

        private void button3_Click(object sender, EventArgs e)
        { timer1.Stop();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            label6.Show();
            label7.Show();
            label8.Show();
            label9.Show();
            DataRow dr = dt.Rows[i];
            if (button3.Text == dr["correction"].ToString())
            {
                MessageBox.Show("bravooo");
                
                j3++;
            }
            else
            {
                MessageBox.Show("faux  la reponce correct est:  " + dr["correction"].ToString());
                
            }
            k++;
            n= i;
       
            if (k < 10)
                button6.Show();
            else
            {
                MessageBox.Show("cette niveau est fini avec " + j3 + "/10 la ");
                this.Close();
               
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            label6.Show();
            label7.Show();
            label8.Show();
            label9.Show();
            timer1.Stop();
            DataRow dr = dt.Rows[i];
            if (button4.Text == dr["correction"].ToString())
            {
                MessageBox.Show("bravooo");
                
                j3++;
            }
            else
            {
                MessageBox.Show("faux  la reponce correct est: " + dr["correction"].ToString());
                
            }
            k++;
            n= i;
      
            if (k < 10)
                button6.Show();
            else
            {
                MessageBox.Show("cette niveau est fini avec " + j3 + "/10 la ");
                this.Close();
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            label6.Show();
            label7.Show();
            label8.Show();
            label9.Show();
            timer1.Stop();
            DataRow dr = dt.Rows[i];
            if (button5.Text == dr["correction"].ToString())
            {
                MessageBox.Show("bravooo");
                
                j3++;
            }
            else
            {
                MessageBox.Show("faux  la reponce correct est: " + dr["correction"].ToString());
                
            }
            k++;
            n = i;
         
            if (k < 10)
                button6.Show();
            else
            {
                MessageBox.Show("cette niveau est fini avec " + j3 + "/10 la ");
                this.Close();
               
            }
            button6.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void level3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                methode3();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            methode4();
        }
        private void methode4()
        {
           
            timer1.Start();
            count++;
            label5.Text = count.ToString();
            if (count == 15)
            {
                if (k == 9)
                {
                    timer1.Stop();
                    MessageBox.Show("cette niveau est fini avec " + j3 + "/10 la note");
                    this.Close();
                   
                }
                else
                {

                    timer1.Stop();
                    MessageBox.Show("pardont la time est fini");

                    k++;
                    methode1();
                }
            }
        
    }

        private void button7_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.Rows[i];
            j3++;
            k++;
            MessageBox.Show("la reponce correct est: " + dr["correction"].ToString());
            
            button7.Hide();
            if (k == 10)
            {
                timer1.Stop();
                MessageBox.Show("cette niveau est fini avec " + j3 + "/10 la note");
                this.Close();

            }
            else
                methode1();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            methode1();
        }
        private void methode1() { 
            label1.Text = "question " + (k + 1)+":";
            
            do
            {
                if (k < 2)
                    i = r.Next(1, 10);
                else
                {
                    if ((k >= 2) && (k < 4))
                        i = r.Next(11, 20);
                    else
                    {
                        if ((k >= 4) && (k < 6))
                            i = r.Next(21, 30);
                        else
                            if ((k >= 6) && (k < 8))
                            i = r.Next(31, 35);
                        else
                            i = r.Next(36, 40);

                    }
                }
            } while (n == i);
            count = 0;
            timer1.Start();
            methode4();
            DataRow dr = dt.Rows[i];
            label2.Text = dr["question"].ToString();
            button5.Text = dr["chois1"].ToString();
            button2.Text = dr["chois2"].ToString();
            button3.Text = dr["chois3"].ToString();
            button4.Text = dr["chois4"].ToString();
            label6.Text = button2.Text;
            label7.Text = button3.Text;
            label8.Text = button4.Text;
            label9.Text = button5.Text;
            button5.Show();
            button4.Show();
            button3.Show();
            button2.Show();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            button6.Hide();



        }

        public void level3_Load(object sender, EventArgs e)
        {
           
            ds.ReadXml(@"C:\Users\User\Desktop\WindowsFormsApp13\WindowsFormsApp13\bin\Debug\level3.xml");
            dt = ds.Tables[0];
            label1.Text = "question " + (k + 1)+":";
            i = r.Next(1, 10);
            DataRow dr = dt.Rows[i];
            label2.Text = dr["question"].ToString();
            button5.Text = dr["chois1"].ToString();
            button2.Text = dr["chois2"].ToString();
            button3.Text = dr["chois3"].ToString();
            button4.Text = dr["chois4"].ToString();
            label6.Text = button2.Text;
            label7.Text = button3.Text;
            label8.Text = button4.Text;
            label9.Text = button5.Text;
            button6.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
           
        }
    }
}
