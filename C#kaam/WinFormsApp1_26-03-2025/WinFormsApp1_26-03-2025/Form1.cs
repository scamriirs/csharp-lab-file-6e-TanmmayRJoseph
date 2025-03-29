namespace WinFormsApp1_26_03_2025
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                this.BackColor = Color.Red;
            }
            else if (radioButton5.Checked == true)
            {
                this.BackColor = Color.Green;
            }
            else
            {
                this.BackColor = Color.Blue;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) {
                MessageBox.Show("you are from indica");

            } else if (radioButton2.Checked == true) {
                MessageBox.Show("you are from america");
            }
            else
            {
                MessageBox.Show("you are from india");
            }
        }
    }
}
