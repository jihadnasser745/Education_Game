using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xmlfile;

namespace projet_info_II
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        { 
            if (checkBox1.Checked) password.UseSystemPasswordChar = false;
            else password.UseSystemPasswordChar = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) confpassword.UseSystemPasswordChar = false;
            else confpassword.UseSystemPasswordChar = true;
        }
        private void submit_Click(object sender, EventArgs e)
        {
            string s1, s2, s3, s4,s5;
            s1 = username.Text.ToUpper();
            s2 = password.Text.ToUpper();
            s3 = confpassword.Text.ToUpper();
            s4 = age.Text.ToUpper();
            s5 = couleurprefe.Text.ToUpper();
            if (s1 == "") label5.Visible = true;
            if (s2 == "") label6.Visible = true;
            if (s3 == "") label7.Visible = true;
            if (s4 == "") label8.Visible = true;
            if (s5 == "") label16.Visible = true;
            else  
            {
                if ((s2 == s3)&&(s1!="")&&(s2!="")&&(s3!="")&&(s4!=""))
               {
                    DataTable dt = xml.ouvrerxml("registration");
                    xml.registrer(s1, s2, s4, s5);
                this.Close();
               }
              else
              {
                MessageBox.Show("il ya une faute dans l' une des password recommencer,ou il faut que tu remplis tout");
                password.Clear();
                confpassword.Clear();
              }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            if(password.Text.Length!=0) label6.Visible = false;
            if (password.Text.Length <= 3)
            {
                label11.Visible = true;
                label10.Visible = false;
                label9.Visible = false;
            }
            if ((password.Text.Length > 3) && (password.Text.Length <= 5))
            {
                label11.Visible = false;
                label10.Visible = true;
                label9.Visible = false;
            }
            if (password.Text.Length > 5)
            {
                label11.Visible = false;
                label10.Visible = false;
                label9.Visible = true;
            }
        }

        private void confpassword_TextChanged(object sender, EventArgs e)
        {
            if(confpassword.Text.Length!=0) label7.Visible = false;
            if (confpassword.Text.Length <= 3)
            {
                label14.Visible = true;
                label13.Visible = false;
                label12.Visible = false;
            }
            if ((confpassword.Text.Length > 3) && (confpassword.Text.Length <= 5))
            {
                label14.Visible = false;
                label13.Visible = true;
                label12.Visible = false;
            }
            if (confpassword.Text.Length > 5)
            {
                label14.Visible = false;
                label13.Visible = false;
                label12.Visible = true;
            }
        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                password.Focus();
        }

        private void password_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                age.Focus();
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                confpassword.Focus();
        }

        private void confpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                age.Focus();
        }

        private void age_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                couleurprefe.Focus();
        }

        private void age_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                confpassword.Focus();
        }

        private void confpassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                password.Focus();
        }

        private void password_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
               username.Focus();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            if(username.Text.Length!=0) label5.Visible = false;
        }

        private void age_TextChanged(object sender, EventArgs e)
        {
            if(age.Text.Length!=0) label8.Visible = false;
        }

        private void phonenb_TextChanged(object sender, EventArgs e)
        {
            if(couleurprefe.Text.Length!=0) label16.Visible = false;
        }

        private void phonenb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                submit.Focus();
        }

        private void submit_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                couleurprefe.Focus();
        }
    }
}
