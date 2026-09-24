namespace StudentDetailsApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;

        private System.Windows.Forms.Button button1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();

            textBox1 = new System.Windows.Forms.TextBox();
            comboBox1 = new System.Windows.Forms.ComboBox();

            radioButton1 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();

            button1 = new System.Windows.Forms.Button();

            SuspendLayout();

            // Form
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(550, 400);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Student Details";

            // Name Label
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(60, 60);
            label1.Text = "Student Name";

            // Name TextBox
            textBox1.Location = new System.Drawing.Point(200, 55);
            textBox1.Size = new System.Drawing.Size(250, 27);

            // Department Label
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(60, 120);
            label2.Text = "Department";

            // Department ComboBox
            comboBox1.Location = new System.Drawing.Point(200, 115);
            comboBox1.Size = new System.Drawing.Size(250, 28);
            comboBox1.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Gender Label
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(60, 180);
            label3.Text = "Gender";

            // Male
            radioButton1.AutoSize = true;
            radioButton1.Location = new System.Drawing.Point(200, 178);
            radioButton1.Text = "Male";

            // Female
            radioButton2.AutoSize = true;
            radioButton2.Location = new System.Drawing.Point(300, 178);
            radioButton2.Text = "Female";

            // Button
            button1.Location = new System.Drawing.Point(200, 250);
            button1.Size = new System.Drawing.Size(120, 40);
            button1.Text = "Show Details";
            button1.Click += button1_Click;

            // Add controls
            Controls.Add(label1);
            Controls.Add(textBox1);

            Controls.Add(label2);
            Controls.Add(comboBox1);

            Controls.Add(label3);
            Controls.Add(radioButton1);
            Controls.Add(radioButton2);

            Controls.Add(button1);

            ResumeLayout(false);
            PerformLayout();
        }
    }
}