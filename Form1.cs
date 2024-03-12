using System;
using System.Windows.Forms;
using ComboBox = System.Windows.Forms.ComboBox;

namespace EventsDelegatesAsgmt
{
    public partial class AiCalc : Form
    {
        public AiCalc()
        {
            InitializeComponent();
            InitializeCalc();
        }

        private void InitializeCalc()
        {
            // Combo box
            ComboBox.Items.AddRange(new object[] { "Add", "Subtract", "Multiply", "Power", "Divide", "Percentage" });
            ComboBox.SelectedIndex = 0;
            // Button
            ButtonCalc.Text = "Calculate";
            ButtonCalc.Click += CalculateButton_Click;
        }

        delegate double Calculate(double num1, double num2);

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            string selectedOp = ComboBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedOp))
            {
                MessageBox.Show("Please select an operation from the dropdown.", "Error");
                return;
            }

            if (double.TryParse(TextBox1.Text, out double num1) && double.TryParse(TextBox2.Text, out double num2))
            {
                Calculate calculationDelegate = null;

                switch (selectedOp)
                {
                    case "Add":
                        calculationDelegate = (a, b) => a + b;
                        break;
                    case "Subtract":
                        calculationDelegate = (a, b) => a - b;
                        break;
                    case "Multiply":
                        calculationDelegate = (a, b) => a * b;
                        break;
                    case "Power":
                        calculationDelegate = (a, b) => Math.Pow(a, b);
                        break;
                    case "Divide":
                        calculationDelegate = (a, b) => (a / b);
                        break;
                    case "Percentage":
                        calculationDelegate = (a, b) => (a * b) / 100;
                        break;
                    default:
                        break;
                }

                if (calculationDelegate != null)
                {
                    double result = calculationDelegate(num1, num2);
                    LabelResult.Text = "Result: " + result.ToString();
                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid numbers.", "Err0r");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
