using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudentResult
{
    public partial class Form1 : Form
    {
        private Button btnViewResult;

        public Form1()
        {
            InitializeComponent();

            btnViewResult = new Button();

            btnViewResult.Text = "View Result";
            btnViewResult.Location = new Point(130, 80);
            btnViewResult.Size = new Size(120, 40);

            btnViewResult.Click += BtnViewResult_Click;

            this.Controls.Add(btnViewResult);

            this.Text = "Student Result";
            this.Size = new Size(400, 250);
        }

        private void BtnViewResult_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to view the result?",
                "Result",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    "Congratulations! You have passed.",
                    "Result");
            }
            else
            {
                MessageBox.Show(
                    "Result viewing cancelled.",
                    "Result");
            }
        }
    }
}