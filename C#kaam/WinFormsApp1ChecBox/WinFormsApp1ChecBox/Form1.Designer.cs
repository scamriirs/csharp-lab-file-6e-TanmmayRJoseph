namespace WinFormsApp1ChecBox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(291, 100);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(110, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Cold Coffee";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(292, 141);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(110, 24);
            checkBox2.TabIndex = 0;
            checkBox2.Text = "Butter Naan";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(292, 171);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(109, 24);
            checkBox3.TabIndex = 0;
            checkBox3.Text = "Romali Roti";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(292, 233);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(115, 24);
            checkBox4.TabIndex = 0;
            checkBox4.Text = "Gulab jamun";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(292, 203);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(114, 24);
            checkBox5.TabIndex = 0;
            checkBox5.Text = "Dal Makhani";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(316, 292);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Confirm Order";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private Button button1;
    }
}
