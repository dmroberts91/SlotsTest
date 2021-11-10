using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random reelRandom = new Random();

            int reelAnswer;
            reelAnswer = reelRandom.Next(1, 10);

            reel1.Text = Convert.ToString(reelAnswer);

            reelAnswer = reelRandom.Next(1, 10);

            reel2.Text = Convert.ToString(reelAnswer);

            reelAnswer = reelRandom.Next(1, 10);

            reel3.Text = Convert.ToString(reelAnswer);

            if (reel1.Text == reel2.Text && reel1.Text == reel3.Text) 
            MessageBox.Show("You have matched all 3!");
        }

       
    }
}
