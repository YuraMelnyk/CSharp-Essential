using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_PartyPlanner
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;

        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDownNumPeople.Value, checkBoxHealthyOption.Checked,checkBoxFuncyDecor.Checked);
            DisplayDinnerPartyCost();

            birthdayParty = new BirthdayParty((int)numericUpDownBirthday.Value, checkBoxFancyBirthday.Checked, textBoxCakeWriting.Text);
            DisplayBirthdayPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.Cost;
            textBoxCost.Text = Cost.ToString("c");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDownNumPeople_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDownNumPeople.Value;
            DisplayDinnerPartyCost();
        }

        private void checkBoxFuncyDecor_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations=checkBoxFuncyDecor.Checked;
            DisplayDinnerPartyCost();
        }

        private void checkBoxHealthyOption_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption=checkBoxHealthyOption.Checked;
            DisplayDinnerPartyCost();
        }

        private void numericUpDownBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numericUpDownBirthday.Value;
            DisplayBirthdayPartyCost();
        }

        private void checkBoxFancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = checkBoxFancyBirthday.Checked;
            DisplayBirthdayPartyCost();
        }

        private void cakeWriting_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = textBoxCakeWriting.Text;
            DisplayBirthdayPartyCost();
        }

        private void DisplayBirthdayPartyCost()
        {
            labelTooLong.Visible = birthdayParty.CakeWritingTooLong;
            decimal cost = birthdayParty.Cost;
            textBoxBirthdayCost.Text = cost.ToString("c");
        }

        private void textBoxCakeWriting_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = textBoxCakeWriting.Text;
            DisplayBirthdayPartyCost();
        }

        private void numericUpDownNumPeople_ValueChanged_1(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDownNumPeople.Value;
            DisplayDinnerPartyCost();

        }

        private void checkBoxFuncyDecor_CheckedChanged_1(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = checkBoxFuncyDecor.Checked;
            DisplayDinnerPartyCost();
        }

        private void checkBoxHealthyOption_CheckedChanged_1(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = checkBoxHealthyOption.Checked;
            DisplayDinnerPartyCost();
        }

        private void textBoxCost_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
