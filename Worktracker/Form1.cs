using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Worktracker
{
    public partial class Worktracker : Form
    {
        // Initialize Worktracker
        public Worktracker()
        {
            InitializeComponent();
        }

        // Thomas
        private void button1_Click(object sender, EventArgs e)
        {
            Thomas.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thomas.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            Thomas.Stop();
        }

        private void Thomas_Tick(object sender, EventArgs e)
        {
            int x = Int32.Parse(label1.Text);
            x += 1;
            label1.Text = Convert.ToString(x);
        }

        // Hannah
        private void button6_Click(object sender, EventArgs e)
        {
            Hannah.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hannah.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = "0";
            Hannah.Stop();
        }

        private void Hannah_Tick(object sender, EventArgs e)
        {
            int x = Int32.Parse(label2.Text);
            x += 1;
            label2.Text = Convert.ToString(x);
        }

        // Sarah
        private void button9_Click(object sender, EventArgs e)
        {
            Sarah.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Sarah.Stop();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label3.Text = "0";
            Sarah.Stop();
        }

        private void Sarah_Tick(object sender, EventArgs e)
        {
            int x = Int32.Parse(label3.Text);
            x += 1;
            label3.Text = Convert.ToString(x);
        }

        // Naomi
        private void button12_Click(object sender, EventArgs e)
        {
            Naomi.Start();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Naomi.Stop();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label4.Text = "0";
            Naomi.Stop();
        }

        private void Naomi_Tick(object sender, EventArgs e)
        {
            int x = Int32.Parse(label4.Text);
            x += 1;
            label4.Text = Convert.ToString(x);
        }

        // Leah
        private void button15_Click(object sender, EventArgs e)
        {
            Leah.Start();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Leah.Stop();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label5.Text = "0";
            Leah.Stop();
        }

        private void Leah_Tick(object sender, EventArgs e)
        {
            int x = Int32.Parse(label5.Text);
            x += 1;
            label5.Text = Convert.ToString(x);
        }

        // Britney
        private void button18_Click(object sender, EventArgs e)
        {
            Britney.Start();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Britney.Stop();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label6.Text = "0";
            Britney.Stop();
        }

        private void Britney_Tick(object sender, EventArgs e)
        {
            int x = Int32.Parse(label6.Text);
            x += 1;
            label6.Text = Convert.ToString(x);
        }

        private void RegularCheck_Tick(object sender, EventArgs e)
        {
            // Thomas
            if (label1.Text == "900")
            {
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Thomas.Stop();
                label1.Text = "0";
            }

            // Hannah
            if (label2.Text == "900")
            {
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Hannah.Stop();
                label2.Text = "0";
            }

            // Sarah
            if (label3.Text == "900")
            {
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Sarah.Stop();
                label3.Text = "0";
            }

            // Naomi
            if (label4.Text == "900")
            {
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Naomi.Stop();
                label4.Text = "0";
            }

            // Leah
            if (label5.Text == "900")
            {
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Leah.Stop();
                label5.Text = "0";
            }

            // Britney
            if (label6.Text == "900")
            {
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Britney.Stop();
                label6.Text = "0";
            }
        }

        private void ThomasWorktracker2_Load(object sender, EventArgs e)
        {
            // Thomas
            //          int y = Int32.Parse(label1.Text);
            //          int thomasMin = y / 60;
            //          int thomasSec = y % 60;
            //          label1.Text = (thomasMin + ":" + thomasSec);
        }

        // ThomasGames
        private void button36_Click(object sender, EventArgs e)
        {
            Thomas2.Start();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Thomas2.Stop();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            label37.Text = "0";
            Thomas2.Stop();
        }

        private void Thomas2_Tick(object sender, EventArgs e)
        {
            int x = Int32.Parse(label37.Text);
            x += 1;
            label37.Text = Convert.ToString(x);
        }

        // HannahGames
        private void button33_Click(object sender, EventArgs e)
        {
            Hannah2.Start();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Hannah2.Stop();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            label36.Text = "0";
            Hannah2.Stop();
        }

        private void Hannah2_Tick(object sender, EventArgs e)
        {
            int x = Int32.Parse(label36.Text);
            x += 1;
            label36.Text = Convert.ToString(x);
        }

        // SarahGames
        private void button30_Click(object sender, EventArgs e)
        {
            Sarah2.Start();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Sarah2.Stop();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            label35.Text = "0";
            Sarah2.Stop();
        }

        private void Sarah2_Tick(object sender, EventArgs e)
        {
            int x = Int32.Parse(label35.Text);
            x += 1;
            label35.Text = Convert.ToString(x);
        }

        // NaomiGames
        private void button27_Click(object sender, EventArgs e)
        {
            Naomi2.Start();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Naomi2.Stop();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            label34.Text = "0";
            Naomi2.Stop();
        }

        private void Naomi2_Tick(object sender, EventArgs e)
        {
            int x = Int32.Parse(label34.Text);
            x += 1;
            label34.Text = Convert.ToString(x);
        }
    }
}