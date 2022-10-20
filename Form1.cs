using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment6_PavelGolovan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string user, computer, result;

        private string generate()
        {
            int n;
            Random rand = new Random();
            n = rand.Next(0, 3) + 1; 
            if (n == 1)
            {
                return "Rock";
            }
            else if (n == 2)
            {
                return "Paper";
            }
            else
            {
                return "Scissors";
            }
        }

        private string winner(string user, string computer)
        {
            if (user == computer)
            {
                return "It's a draw!\nTry again.";
            }
            else if (user == "Rock" && computer == "Scissors" ||
                user == "Scissors" && computer == "Paper" ||
                user == "Paper" && computer == "Rock")
            {
                return "You win!";
            }
            else
            {
                return "You lose!";
            }
        }

        private void pictures(string user, string computer)
        {
            if (user == "Rock")
            {
                userPictureBox.Image = assignment6_PavelGolovan.Properties.Resources.Rock;
            }
            else if (user == "Paper")
            {
                userPictureBox.Image = assignment6_PavelGolovan.Properties.Resources.Paper;
            }
            else
            {
                userPictureBox.Image = assignment6_PavelGolovan.Properties.Resources.Scissors;
            }
            if (computer == "Rock")
            {
                computerPictureBox.Image = assignment6_PavelGolovan.Properties.Resources.Rock;
            }
            else if (computer == "Paper")
            {
                computerPictureBox.Image = assignment6_PavelGolovan.Properties.Resources.Paper;
            }
            else
            {
                computerPictureBox.Image = assignment6_PavelGolovan.Properties.Resources.Scissors;
            }
        }

        private void end(string result)
        {
            if (result == "You win!")
            {
                resultLabel.Text = result;
                userPictureBox.BackColor = Color.Lime;
                computerPictureBox.BackColor = Color.Red;
                rockButton.Enabled = false;
                paperButton.Enabled = false;
                scissorsButton.Enabled = false;
            }
            else if (result == "You lose!")
            {
                resultLabel.Text = result;
                userPictureBox.BackColor = Color.Red;
                computerPictureBox.BackColor = Color.Lime;
                rockButton.Enabled = false;
                paperButton.Enabled = false;
                scissorsButton.Enabled = false;
            }
            else
            {
                computer = generate();
                resultLabel.Text = result;
                userPictureBox.BackColor = Color.Gold;
                computerPictureBox.BackColor = Color.Gold;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            computer = generate();
        }

        private void rockButton_Click(object sender, EventArgs e)
        {
            user = "Rock";
            pictures(user, computer);
            result = winner(user, computer);
            end(result);
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            user = "Paper";
            pictures(user, computer);
            result = winner(user, computer);
            end(result);
        }

        private void scissorsButton_Click(object sender, EventArgs e)
        {
            user = "Scissors";
            pictures(user, computer);
            result = winner(user, computer);
            end(result);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            computer = generate();
            resultLabel.Text = "";
            userPictureBox.Image = null;
            computerPictureBox.Image = null;
            userPictureBox.BackColor = SystemColors.GradientActiveCaption;
            computerPictureBox.BackColor = SystemColors.GradientActiveCaption;
            rockButton.Enabled = true;
            paperButton.Enabled = true;
            scissorsButton.Enabled = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}