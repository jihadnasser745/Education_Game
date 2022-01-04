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
using notes;
using System.Media;
namespace projet_info_II
{
    public partial class registration : Form
    {
        private SoundPlayer _music0;
        public registration()
        {
            InitializeComponent();
            _music0 = new SoundPlayer("music.wav");
        }
        private void login_Click(object sender, EventArgs e)//Login
        {
            string s1, s2, s3, s4;
            s1 = username.Text.ToUpper();
            s2 = password.Text.ToUpper();
            if ((s1 == "")) label4.Visible = true;
            if ((s2 == "")) label5.Visible = true;

            {
                int a;
                DataTable dt = xml.ouvrerxml("registration");
                for (a = 0; a < dt.Rows.Count; a++)
                {
                    s3 = xml.DeChiffrer(dt.Rows[a][0].ToString());
                    s4 = xml.DeChiffrer(dt.Rows[a][1].ToString());

                    if ((s1 == s3) && (s2 == s4))
                    {
                        show s = new show(1);
                        s.Show();
                        note.s = username.Text.ToUpper();
                        this.Hide();
                        break;
                    }

                }
                {
                    if (a == dt.Rows.Count)
                    {
                        if ((s1 != xml.DeChiffrer(dt.Rows[a - 1][0].ToString())) || (s2 != xml.DeChiffrer(dt.Rows[a - 1][1].ToString())))
                        {
                            MessageBox.Show("Ton Username ou ton password sont faux!");
                            username.Clear();
                            password.Clear();
                        }
                    }
                    else
                    {
                        if ((s1 != xml.DeChiffrer(dt.Rows[a][0].ToString())) || (s2 != xml.DeChiffrer(dt.Rows[a][1].ToString())))
                        {
                            MessageBox.Show("Ton Username ou ton password sont faux!");
                            username.Clear();
                            password.Clear();
                        }
                    }

                }
            }

        }


        private void signup_Click(object sender, EventArgs e)
        {
            Signup si = new Signup();
            si.Show();
        }

        private void registration_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)password.UseSystemPasswordChar = false;
            else password.UseSystemPasswordChar = true;
        }
        private void exit_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            if (username.Text.Length != 0) label4.Visible = false;
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            if (password.Text.Length != 0) label5.Visible = false;
        }

        private void forgetpass_Click(object sender, EventArgs e)
        {
            oublier ou = new oublier();
            ou.Show();
        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                password.Focus();
        }

        private void password_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                username.Focus();
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                login.Focus();
        }

        public void pictureBox3_Click(object sender, EventArgs e)
        {
            _music0.Play();
            pictureBox4.Visible = true;
            pictureBox3.Visible = false;
        }

        public void pictureBox4_Click(object sender, EventArgs e)
        {
            _music0.Stop();
            pictureBox4.Visible = false;
            pictureBox3.Visible = true;
        }
    }
}
