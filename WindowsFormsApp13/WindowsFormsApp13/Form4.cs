using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp13
{
    public partial class level1 : Form
    {
        DataSet ds = new DataSet();
        DataTable dt;
        public int j1 = 0;
        int i, k = 0, n;
        Random r = new Random();
        int count;
        public level1()
        {
            InitializeComponent();
            timer1.Start();
        }

        public void level1_Load(object sender, EventArgs e)
        {
            
            label1.Text = "question " + (k + 1) + ":";

            ds.ReadXml(@"C:\Users\User\Desktop\WindowsFormsApp13\WindowsFormsApp13\bin\Debug\level1.xml");
            dt = ds.Tables[0];
            i = r.Next(1, 10);
            DataRow dr = dt.Rows[i];
            label3.Text = dr["question"].ToString();
            button1.Hide();
            textBox2.Focus();
            
                
            


        }



        public void aller_Click(object sender, EventArgs e)
        {
            methode1();
        }
        public void methode1()
        {
            DataRow dr = dt.Rows[i];


            if (textBox2.Text.Length != 0)
            {
                timer1.Stop();


                if (dr["answers"].ToString().Trim() == textBox2.Text.ToString().Trim())
                {
                    aller.Hide();
                    MessageBox.Show("bravo");
                    timer1.Stop();
                    j1++;
                    k++;

                }
                else
                {
                    timer1.Stop();
                    MessageBox.Show("faux la reponce correct est  " + dr["answers"].ToString());
                    aller.Hide();
                    k++;
                }
            }
            else
            {
                MessageBox.Show("pardon calculer l'exercice");
                button1.Hide();


            }
            string s = textBox2.Text.ToString();
            n = i;
            if (k < 10)
            {
                if (s.Length != 0)
                    button1.Show();
            }
            else
            {
                MessageBox.Show("cette niveau est fini avec " + j1 + "/10 la note");
                this.Close();
                
            }
        }




        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
          

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {


        }

        private void question_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {


        }

        private void level1_KeyDown(object sender, KeyEventArgs e)
        {






        }

        public void button1_click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (aller.Visible == true)
                    methode1();
                else
                    methode2();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            methode3();
        }
        private void methode3() {
            if (j1 > 6)
                button2.Show();


            DataRow dr = dt.Rows[i];
            timer1.Start();          
            count++;
            label4.Text = count.ToString();
            if (count == 15)
            {
                if (k == 9)
                {
                    timer1.Stop();
                    MessageBox.Show("cette niveau est fini avec " + j1 + "/10 la note ");
                    this.Close();
                    
                }
                else
                {

                    timer1.Stop();

                    MessageBox.Show("pardont la time est fini et la reponce correct est"+dr["answers"].ToString());

                    k++;
                    methode2();
                }
            }
            
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            methode2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.Rows[i];
            j1++;
            k++;
            MessageBox.Show("la reponce correct est:" + dr["answers"].ToString());
            
            button2.Hide();
            if (k == 10)
            {
                timer1.Stop();
                MessageBox.Show("cette niveau est fini avec " + j1 + "/10 la note ");
                this.Close();

            }
            else
                methode2();
        }

        private void methode2()
        {
            label1.Text = "question " + (k + 1) + ":";
            aller.Show();
            textBox2.Clear();
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
                            i = r.Next(31, 40);
                        else
                            i = r.Next(41, 50);

                    }
                }
            } while (n == i);
            count = 0;
            timer1.Start();
            methode3();
            DataRow dr = dt.Rows[i];
            label3.Text = dr["question"].ToString();
            button1.Hide();
            textBox2.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {




        }


    }
}

    

