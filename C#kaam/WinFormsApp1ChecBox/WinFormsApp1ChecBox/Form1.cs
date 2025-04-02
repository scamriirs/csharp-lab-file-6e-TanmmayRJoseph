namespace WinFormsApp1ChecBox
{
    public partial class Form1 : Form
    {
        public string sametext = "your order contains:";
        public int total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string orderDetails = sametext; 
            bool hasOrder = false; 

            if (checkBox1.Checked == true)
            {
                orderDetails += "\n - Cold Coffee";
                total += 20;
                hasOrder = true;
            }
            if (checkBox2.Checked == true)
            {
                orderDetails += "\n - Romali Roti";
                total += 50;
                hasOrder = true;
            }
            if (checkBox3.Checked == true)
            {
                orderDetails += "\n - Dal Makhani";
                total += 90;
                hasOrder = true;
            }
            if (checkBox4.Checked == true)
            {
                orderDetails += "\n - Gulab Jamun";
                total += 80;
                hasOrder = true;
            }

            if (!hasOrder) 
            {
                MessageBox.Show("You have selected nothing.", "Order Status");
            }
            else
            {
                MessageBox.Show(orderDetails + $"\n\nYour total bill is: ₹{total}", "Order Summary");
            }
        }
    }
}
