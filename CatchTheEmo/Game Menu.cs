using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace CatchTheEmoji
{
    public partial class Game_Menu : Form
    {
        public Game_Menu()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        { }

        public void Return()
        { Random rand = new Random();
                int w = rand.Next(0, 2);
                if (w == 0)
                {
                    PicFirstEmo.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = true;
                }
                else if (w == 1)
                {
                    PicFirstEmo.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = true;
                }
                else if (w == 2)
                {
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    PicFirstEmo.Visible = true;
                }  
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public int value;
        private void button1_Click(object sender, EventArgs e)
        {
            ScoreBox.Text = "0";
            BoxGameOver.Visible = false;
            
            if (int.TryParse(TimeBox.Text, out value))
                if (radioEazy.Checked)
                { PicFirstEmo.Visible = true;
                    Start_btn.Enabled = false;
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    timer2.Start();
                }
                else if (radioMedium.Checked)
                {
                    PicFirstEmo.Visible = true;
                    Start_btn.Enabled = false;
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    timer2.Start();
                }
                else if (radioHard.Checked)
                {
                    PicFirstEmo.Visible = true;
                    Start_btn.Enabled = false;
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    timer2.Start();
                }
                else { MessageBox.Show("Please, choose the difficulty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            
        }

        Class1 cc = new Class1();
        private void Game_Menu_Load(object sender, EventArgs e)
        {
            LabelChange.Text = "Welcome,\n " + Form1.SetValueForText1;
            PicFirstEmo.Visible = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            TimeBox.Text = Convert.ToString(30);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            TimeBox.Text = Convert.ToString(20);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            TimeBox.Text = Convert.ToString(10);   
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            for (int w = Convert.ToInt32(ScoreBox.Text); w < 26 && w %5==0 ; w ++)
            {
                Return();
                PicFirstEmo.Width -= 10;
                PicFirstEmo.Height -= 5;
                pictureBox5.Width -= 10;
                pictureBox5.Height -= 5;
                pictureBox6.Width -= 10;
                pictureBox6.Height -= 5;
                Game_Menu.ActiveForm.Height += 10;
                Game_Menu.ActiveForm.Width += 10;
            }
            for (int w = Convert.ToInt32(ScoreBox.Text); w % 5 == 0; w++)
                TimeBox.Text = (int.Parse(TimeBox.Text) + 7).ToString();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int x = rand.Next(207, this.ClientSize.Width - PicFirstEmo.Width);
            int y = rand.Next(207, this.ClientSize.Height - PicFirstEmo.Height);
            PicFirstEmo.Location = new Point(x, y);
            ScoreBox.Text = (int.Parse(ScoreBox.Text) + cc.t1).ToString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int x = rand.Next(207, this.ClientSize.Width - PicFirstEmo.Width);
            int y = rand.Next(207, this.ClientSize.Height - PicFirstEmo.Height);
            pictureBox5.Location = new Point(x, y);
            ScoreBox.Text = (int.Parse(ScoreBox.Text) + cc.t1).ToString();
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int x = rand.Next(207, this.ClientSize.Width - PicFirstEmo.Width);
            int y = rand.Next(207, this.ClientSize.Height - PicFirstEmo.Height);
            pictureBox6.Location = new Point(x, y);
            ScoreBox.Text = (int.Parse(ScoreBox.Text) + 1).ToString();
        }
        private void BoxText_TextChanged(object sender, EventArgs e)
        {
            if (TimeBox.Text == 0.ToString())
            { 
            timer2.Stop();
            BoxGameOver.Text = "Game Over! Your Score: " + ScoreBox.Text;
            BoxGameOver.Visible = true;
            PicFirstEmo.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            Start_btn.Enabled = true;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            TimeBox.Text = (int.Parse(TimeBox.Text) - 1).ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BoxGameOver_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
