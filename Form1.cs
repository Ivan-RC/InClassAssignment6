using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Ivan Rivas
/// This is my own work
/// </summary>

namespace InClassAssignment6
{
    public partial class DiceRoll : Form
    {

        static int count = 0;
        public DiceRoll()
        {

            InitializeComponent();
        }
        private void btn1_rollDice_Click(object sender, EventArgs e)
        {
            Dice a1 = new Dice(6);
            Dice a2 = new Dice(6);
            label1_a1.Text = a1.rollDie().ToString();
            label2_a2.Text = a2.rollDie().ToString();

            String strRoll1 = label1_a1.Text;
            int roll1 = int.Parse(strRoll1);
            String strRoll2 = label2_a2.Text;
            int roll2 = int.Parse(strRoll2);

            count++;
            if (roll1 == 1 && roll2 == 1)
            {
                MessageBox.Show("It took you " + count + " rolls to get snake eyes.");
            }
            
        }
    }
}