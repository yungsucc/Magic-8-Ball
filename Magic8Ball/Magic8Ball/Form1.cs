using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic8Ball
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            if(txtQuestion.Text == "")
            {
                txtError.Visible = true;
                txtError.Text = "You didnt enter any question!";
            }
            else
            {
                string[] answers = { "Yes definitely.", "No.", "Most likely.", "Very doubtful.", "Ask again later.", "Dont count on it.", "It is certain.", "Without a doubt." };
                var random = new Random();
                int answerindex = random.Next(answers.Length);
                txtBall.Text = answers[answerindex];
            }
        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtBall_Click(object sender, EventArgs e)
        {

        }
    }
}
