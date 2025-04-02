using System;
using System.Windows.Forms;

namespace WinFormsApp1BMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double t1 = double.Parse(textBox1.Text);
                double t2 = double.Parse(textBox2.Text);

                // Convert height from cm to meters
                t1 = t1 / 100;

                // Check if height and weight are valid
                if (t1 <= 0 || t2 <= 0)
                {
                    MessageBox.Show("Height and weight must be positive numbers.", "Error");
                    return;
                }

                double bmi = t2 / (t1 * t1);

                bool male = radioButton2.Checked;
                string category;

                if (male)
                {
                    if (bmi < 18.5) category = "Underweight";
                    else if (bmi < 25) category = "Normal weight";
                    else if (bmi < 30) category = "Overweight";
                    else category = "Obese";
                }
                else
                {
                    if (bmi < 18) category = "Underweight";
                    else if (bmi < 24) category = "Normal weight";
                    else if (bmi < 29) category = "Overweight";
                    else category = "Obese";
                }

                MessageBox.Show($"Your BMI is {bmi:F2}\nCategory: {category}", "BMI Result");
            }
            catch
            {
                MessageBox.Show("Enter valid numbers!", "Error");
            }
        }
    }
}
