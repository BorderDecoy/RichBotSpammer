using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form2 : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Spammer.Start();
        }

        private void Spammer_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(richTextBox1.Text);
            SendKeys.Send("{ENTER}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Spammer.Stop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
        int x = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                label3.ForeColor = Color.Green;
                TopMost = true;
                this.label3.Text = "ON!";
                x++;
            }
            else
            {
                label3.ForeColor = Color.Red;
                this.label3.Text = "OFF!";
                TopMost = false;
                x--;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 esr = new Form3();
            esr.Show();
        }
    }
}
