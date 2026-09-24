using System;
using System.Windows.Forms;

namespace StudentDetailsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("Information Technology");
            comboBox1.Items.Add("Computer Science");
            comboBox1.Items.Add("Electronics");
            comboBox1.Items.Add("Mechanical");
            comboBox1.Items.Add("Civil");

            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string department = comboBox1.SelectedItem.ToString();

            string gender = "";

            if (radioButton1.Checked)
            {
                gender = "Male";
            }
            else if (radioButton2.Checked)
            {
                gender = "Female";
            }
            else
            {
                gender = "Not Selected";
            }

            string message =
                "Student Details\n" +
                "----------------------\n" +
                "Name : " + name + "\n" +
                "Department : " + department + "\n" +
                "Gender : " + gender;

            MessageBox.Show(
                message,
                "Student Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}