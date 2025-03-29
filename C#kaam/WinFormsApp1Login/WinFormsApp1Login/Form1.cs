namespace WinFormsApp1Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Enter all required fields");
            }
            else
            {
                MessageBox.Show("Welcome back bhai/bhn");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox3.Text);
            int b = Convert.ToInt32(textBox4.Text);
            int c = a + b;

            textBox5.Text = c.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int d = Convert.ToInt32(textBox3.Text);
            int ef = Convert.ToInt32(textBox4.Text);
            int f = d - ef;

            textBox5.Text = f.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int h = Convert.ToInt32(textBox3.Text);
            int t = Convert.ToInt32(textBox4.Text);
            int y = h / t;

            textBox5.Text = y.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int af = Convert.ToInt32(textBox3.Text);
            int bf = Convert.ToInt32(textBox4.Text);
            int cf = af / bf;

            textBox5.Text = cf.ToString();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "" || textBox4.Text != "" || textBox5.Text != "")
            {
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            int fg = Convert.ToInt32(textBox6.Text);

            double hj = ((fg - 32) / 1.8);
            textBox7.Text = hj.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}