using NextBigerNumberWithTheSameDigits.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextBiggerNumberWFA
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            long input;
            resultLabel.Text = long.TryParse(inputTextBox.Text, out input) ? 
                Kata.NextBiggerNumber(input).ToString() : "Please Enter a number";
            //resultLabel.Text = Kata.NextBiggerNumber(long.Parse(inputTextBox.Text)).ToString();
        }
    }
}
