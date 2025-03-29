namespace WinFormsApp1ApplicationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;
            string c = textBox3.Text;
            string gender = radioButton1.Checked ? "Male" : "Female";

            MessageBox.Show(string.Format("You selected {0}, {1}, {2}, {3}", a, b, c, gender));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            double a = Convert.ToDouble (textBox4.Text);
            double b =Convert.ToDouble( textBox5.Text);

            // Determine gender
            string gender = radioButton3.Checked ? "Male" : "Female";

            // Correct BMI formula
            double BMI = b / (a * a);

            // Determine BMI category
            string category;
            if (BMI < 18.5)
                category = "Underweight";
            else if (BMI >= 18.5 && BMI < 24.9)
                category = "Normal weight";
            else if (BMI >= 25 && BMI < 29.9)
                category = "Overweight";
            else
                category = "Obese";

            // Display result
            MessageBox.Show($"Hello, you are {gender}. Your BMI is {BMI:F2}, which is categorized as {category}.");
        

    }
    }
}
