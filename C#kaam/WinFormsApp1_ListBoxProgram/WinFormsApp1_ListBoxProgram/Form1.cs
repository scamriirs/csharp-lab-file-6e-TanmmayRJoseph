namespace WinFormsApp1_ListBoxProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                MessageBox.Show("You selected: " + listBox1.SelectedItem.ToString(), "Selected Item");
            }
            else
            {
                MessageBox.Show("Please select an item from the list.", "No Selection");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
