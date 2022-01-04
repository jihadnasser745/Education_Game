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
    public partial class oublier : Form
    {
        public oublier()
        {
            InitializeComponent();
        }
        int i;
        private void changer_Click(object sender, EventArgs e)
        {
            string s1, s4,s5,s11,s44,s55;
            s1 = username.Text;
            s4 = age.Text.ToString();
            s5 = couleurprefe.Text.ToString();
            if ((s1 == "")) label5.Visible = true;
            if ((s4 == "")) label8.Visible = true;
            if ((s5 == "")) label16.Visible = true;
            {
                DataTable dt = xml.ouvrerxml("registration");
                for (i = 0; i < dt.Rows.Count; i++)
                {
                    s11 = xml.DeChiffrer(dt.Rows[i][0].ToString());
                    s44 = xml.DeChiffrer(dt.Rows[i][2].ToString());
                    s55 = xml.DeChiffrer(dt.Rows[i][3].ToString());
                    if ((s1 == s11) && (s4 == s44) && (s5 == s55))
                    {
                        panel1.Visible = true;
                        done.Visible = true;
                        panel2.Visible = false;
                        changer.Visible = false;
                        break;
                    }
                }
                if((i>dt.Rows.Count)&&(s1!="")&&(s4!="")&&(s5!=""))
                {
                    MessageBox.Show("Tu ne peut pas changer ton password car tu es oublier les reponces!!");
                    username.Clear();
                    age.Clear();
                    couleurprefe.Clear();

                }

            }
        }

        private void newpassword_TextChanged(object sender, EventArgs e)
        {
            if ((newpassword.Text.Length != 0)) label6.Visible = false;
            if (newpassword.Text.Length <= 3)
            {
                label11.Visible = true;
                label10.Visible = false;
                label9.Visible = false;
            }
            if ((newpassword.Text.Length > 3) && (newpassword.Text.Length <= 5))
            {
                label11.Visible = false;
                label10.Visible = true;
                label9.Visible = false;
            }
            if (newpassword.Text.Length > 5)
            {
                label11.Visible = false;
                label10.Visible = false;
                label9.Visible = true;
            }
        }

        private void confpassword_TextChanged(object sender, EventArgs e)
        {
            if (confpassword.Text.Length != 0) label7.Visible = false;
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
        private void done_Click(object sender, EventArgs e)
        {
            string s2, s3;
            DataSet dl1 = new DataSet();//bool ok = true; 
            dl1.ReadXml(@"C:\Users\User\Desktop\projet info II\projet info II\bin\Debug\registration.xml");//8yarto
            DataTable dt1 = dl1.Tables[0];
            {
                    s2 = xml.Chiffrer(newpassword.Text.ToUpper());
                    s3 = xml.Chiffrer(confpassword.Text.ToUpper());
                    if ((s2 == "")) label6.Visible = true;
                    if ((s3 == "")) label7.Visible = true;
                    if ((s2 == s3)&&(s2!="")&&(s3!=""))
                    {
                        dt1.Rows[i][1] = xml.Chiffrer(newpassword.Text);
                        dl1.WriteXml(@"C:\Users\User\Desktop\projet info II\projet info II\bin\Debug\registration.xml");
                        this.Close();
                        
                    }
                    else
                    {
                        MessageBox.Show("les Passwords sont differents");
                        newpassword.Clear();
                        confpassword.Clear();
                        newpassword.Focus();
                    }
                }
                 
                //if (i == dt.Rows.Count)
                {
                  // ok = false;
                  //  MessageBox.Show("tu ne peut pas changer ton password, car tu a oublier les reponses du help");
                }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) newpassword.UseSystemPasswordChar = false;
            else newpassword.UseSystemPasswordChar = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) confpassword.UseSystemPasswordChar = false;
            else confpassword.UseSystemPasswordChar = true;
        }

        private void oublier_Load(object sender, EventArgs e)
        {
            username.Focus();
            done.Visible = false;
        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                age.Focus();
        }

        private void age_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                couleurprefe.Focus();
        }

        private void phonenb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                newpassword.Focus();
        }

        private void newpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                confpassword.Focus();
        }

        private void confpassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                newpassword.Focus();
        }

        private void newpassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
               couleurprefe.Focus();
        }

        private void phonenb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                age.Focus();
        }

        private void age_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                username.Focus();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            if (username.Text.Length != 0) label5.Visible = false;
        }

        private void age_TextChanged(object sender, EventArgs e)
        {
            if ((age.Text.Length != 0)) label8.Visible = false;
        }

        private void phonenb_TextChanged(object sender, EventArgs e)
        {
            if (couleurprefe.Text.Length != 0) label16.Visible = false;
        }

        private void confpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                done.Focus();
        }
    }
}
