using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assgn1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public static int GetCurrentAge(DateTime dateOfBirth)
        {
            DateTime now = new DateTime(2022, 04, 19); // specifically took date put in variable
            int years = now.Year - dateOfBirth.Year;
            
            if (now.Month < dateOfBirth.Month || (now.Month == dateOfBirth.Month && now.Day < dateOfBirth.Day))
                --years;
            return years;
        }

        public static int GetCurrentAge2(DateTime dateOfBirth)
        {
            DateTime now = new DateTime(2022, 04, 19); // separate condition for getting month
            int month = now.Month;
                
            return month;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
            int age = GetCurrentAge(dateTimePicker1.Value);
           int month = GetCurrentAge2(dateTimePicker1.Value);


            // age is available for print

            if (age < 18 && month == 4)
            
            {
                MessageBox.Show( textBox1.Text + " is underage");//("Age should be above 18 years " + " age is " + textBox1.Text);
            }


               else if (age < 18 )
                {
                MessageBox.Show(textBox1.Text + " is underage");//("Age should be above 18 years " + " age is " + textBox1.Text); 
                }
            
            if (age >= 18 && month == 4 )
            {
                MessageBox.Show(textBox1.Text + " Is welcome!");//("is above 18 years " + " age is  " + textBox1.Text);
            }
           else if (age >= 18 )
            {
                MessageBox.Show(textBox1.Text + " Is welcome!");//"is above 18 years " + " age is  " + textBox1.Text);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
