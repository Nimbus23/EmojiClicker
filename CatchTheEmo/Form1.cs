using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchTheEmoji
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string SetValueForText1 = "";
        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            SetValueForText1 = textBox1.Text;
        }
     

        public void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength >= 1)
            {
                Game_Menu gm = new Game_Menu();
                gm.ShowDialog();
               
            }
            else { MessageBox.Show("Please, enter your name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
