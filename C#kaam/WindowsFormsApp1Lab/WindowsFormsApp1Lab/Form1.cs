using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
          
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.ForeColor = colorDialog.Color;
                textBox1.Text = "Background Color: " + colorDialog.Color.Name;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "hello mam kem choo";
            MessageBox.Show(message);
            textBox1.Text = message; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // File opener dialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open a File";
            openFileDialog.Filter = "Text Files|*.txt|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = "Selected File: " + openFileDialog.FileName;
                MessageBox.Show(selectedFile, "File Opened");
                textBox1.Text = selectedFile;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            FontDialog fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog.Font; 
                textBox1.Text = "Selected Font: " + fontDialog.Font.Name + ", " + fontDialog.Font.Size + "pt";
            }
        }
    }
}
