using System.IO;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private double resultValue = 0;
        private string operationPerformed = "";
        private bool isOperationPerformed = false;
        private bool isDarkTheme = true;
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnNumber_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string number = button.Tag.ToString();
            if ((txtDisplay.Text == "0") || isOperationPerformed)
                txtDisplay.Clear();

            isOperationPerformed = false;

            if (number == "," && txtDisplay.Text.Contains(","))
                return;

            txtDisplay.Text += number;
        }

        private void BtnOperation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string newOperation = button.Tag.ToString();

            if (operationPerformed != "")
            {
                CalculateResult(); // Считаем прошлый шаг
            }
            else
            {
                if (!double.TryParse(txtDisplay.Text, out resultValue))
                {
                    MessageBox.Show("Ошибка формата данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            operationPerformed = newOperation;
            isOperationPerformed = true;
        }
        private void CalculateResult()
        {
            double currentInput = 0;
            if (!double.TryParse(txtDisplay.Text, out currentInput)) return;

            switch (operationPerformed)
            {
                case "+": resultValue += currentInput; break;
                case "-": resultValue -= currentInput; break;
                case "*": resultValue *= currentInput; break;
                case "/":
                    if (currentInput == 0)
                    {
                        MessageBox.Show("Деление на ноль невозможно!", "Математическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        button16_Click(null, null);
                        return;
                    }
                    resultValue /= currentInput;
                    break;
                default:
                    return;
            }
            txtDisplay.Text = resultValue.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            resultValue = 0;
            operationPerformed = "";
            isOperationPerformed = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Текстовые файлы (*.txt)|*.txt";
                sfd.Title = "Сохранить результат вычислений";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, txtDisplay.Text);
                    MessageBox.Show("Результат сохранен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Текстовые файлы (*.txt)|*.txt";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string content = File.ReadAllText(ofd.FileName).Trim();

                    if (double.TryParse(content, out double loadedValue))
                    {
                        txtDisplay.Text = loadedValue.ToString();
                        resultValue = loadedValue;
                        isOperationPerformed = false;
                    }
                    else
                    {
                        MessageBox.Show("Файл поврежден или содержит неверный формат.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            isDarkTheme = !isDarkTheme;


            Color backColor = isDarkTheme ? Color.FromArgb(45, 45, 48) : SystemColors.Control;
            Color buttonColor = isDarkTheme ? Color.FromArgb(63, 63, 70) : SystemColors.ControlLight;
            Color textColor = isDarkTheme ? Color.White : Color.Black;
            Color displayBack = isDarkTheme ? Color.Black : Color.White;

            this.BackColor = backColor;
            txtDisplay.BackColor = displayBack;
            txtDisplay.ForeColor = textColor;

            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    control.BackColor = buttonColor;
                    control.ForeColor = textColor;

                    if (control is Button btn)
                    {
                        btn.FlatStyle = isDarkTheme ? FlatStyle.Flat : FlatStyle.Standard;
                        btn.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
                    }
                }
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            CalculateResult();
            operationPerformed = "";
        }
    }
}
