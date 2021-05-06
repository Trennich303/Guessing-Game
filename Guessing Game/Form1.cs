using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guessing_Game
{
    public partial class GuessButton : Form
    {
        public GuessButton()
        {
            InitializeComponent();
            Random randGen = new Random();
            ActualValue = randGen.Next(1, 101);
        }

        double ActualValue;
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            
             int PlayerGuess = Convert.ToInt32(InputTextBox.Text);

            if (PlayerGuess < ActualValue)
            {
                OutputTextBox.Text = "To Low";
            }
            else if (PlayerGuess > ActualValue)
            {
                OutputTextBox.Text = "To High";
            }
            else
            {
                OutputTextBox.Text = "You Got It!";
            }
        }
    }
}
