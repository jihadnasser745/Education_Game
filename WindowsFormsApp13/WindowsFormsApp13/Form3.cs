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
    public partial class math : Form
    {
        public math()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            
      }

        private void math_Load(object sender, EventArgs e)
        {

        }

        private void level1_Click(object sender, EventArgs e)
        {
            level1 f1 = new level1();
            f1.Show();
            

            
        }

        private void level2_Click(object sender, EventArgs e)
        {
            level2 f2 = new level2();
            f2.Show();
            

        }

        private void level4_Click(object sender, EventArgs e)
        {
            level4 f2 = new level4();
            f2.Show();
            
            
        }

        private void level3_Click(object sender, EventArgs e)
        {
            level3 f2 = new level3();
            f2.Show();
            

        }

        private void level5_Click(object sender, EventArgs e)
        {
            level5 f2 = new level5();
            f2.Show();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            projet_info_II.Game g = new projet_info_II.Game();
            g.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            projet_info_II.registration r = new projet_info_II.registration();
            r.Show();
            Close();
        }
    }
}
