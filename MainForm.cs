using System;
using System.Windows.Forms;

namespace AdvancedCalculator
{
    public partial class MainForm : Form
    {

        string usedOperator;

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            string operation = labelOperation.Text;
            if (operation.Length != 0) 
            {
                labelOperation.Text = "";
                if (usedOperator != null) usedOperator = null;
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string operation = labelOperation.Text;
            int operationLength = operation.Length;
            if (operationLength != 0 && !operation.Contains("="))
            {
                if (usedOperator != null && operation.EndsWith(usedOperator)) 
                    usedOperator = null;
                string newOperation = operation.Substring(0, operationLength - 1);
                labelOperation.Text = newOperation;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string operation = labelOperation.Text;
            if (operation != "" && usedOperator == null)
            {
                usedOperator = "+";
                labelOperation.Text += "+";
            }
        }
        private void buttonSub_Click(object sender, EventArgs e)
        {
            string operation = labelOperation.Text;
            if (operation != "" && usedOperator == null)
            {
                usedOperator = "-";
                labelOperation.Text += "-";
            }
        }
        private void buttonMul_Click(object sender, EventArgs e)
        {
            string operation = labelOperation.Text;
            if (operation != "" && usedOperator == null)
            {
                usedOperator = "×";
                labelOperation.Text += "×";
            }
        }
        private void buttonDiv_Click(object sender, EventArgs e)
        {
            string operation = labelOperation.Text;
            if (operation != "" && usedOperator == null)
            {
                usedOperator = "÷";
                labelOperation.Text += "÷";
            }
        }
        private void buttonMod_Click(object sender, EventArgs e)
        {
            string operation = labelOperation.Text;
            if (operation != "" && usedOperator == null)
            {
                usedOperator = "%";
                labelOperation.Text += "%";
            }
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            string operation = labelOperation.Text;
            if (!operation.Contains("="))
            {
                if (usedOperator == null)
                {
                    if (!operation.Contains("."))
                    {
                        if (operation.Length == 0) labelOperation.Text += "0.";
                        else labelOperation.Text += ".";
                    }
                }
                else
                {
                    int usedOperatorIndex = operation.IndexOf(usedOperator);
                    string secondNumber = operation.Substring(usedOperatorIndex + 1);
                    if (!secondNumber.Contains("."))
                    {
                        if (secondNumber.Length == 0) labelOperation.Text += "0.";
                        else labelOperation.Text += ".";
                    }
                }
            }
        }
        private void buttonZero_Click(object sender, EventArgs e)
        {
            string operation = labelOperation.Text;
            if (!operation.Contains("=")) labelOperation.Text += "0";
        }
        private void buttonDoubleZero_Click(object sender, EventArgs e)
        {
            string operation = labelOperation.Text;
            if (!operation.Contains("=")) labelOperation.Text += "00";
        }
        private void buttonOne_Click(object sender, EventArgs e)
        {
            string operation = labelOperation.Text;
            if (!operation.Contains("=")) labelOperation.Text += "1";
        }
        private void buttonTwo_Click(object sender, EventArgs e)
        {
            string operation = labelOperation.Text;
            if (!operation.Contains("=")) labelOperation.Text += "2";
        }
        private void buttonThree_Click(object sender, EventArgs e)
        {
            string operation = labelOperation.Text;
            if (!operation.Contains("=")) labelOperation.Text += "3";
        }
        private void buttonFour_Click(object sender, EventArgs e)
        {
            string operation = labelOperation.Text;
            if (!operation.Contains("=")) labelOperation.Text += "4";
        }
        private void buttonFive_Click(object sender, EventArgs e)
        {
            string operation = labelOperation.Text;
            if (!operation.Contains("=")) labelOperation.Text += "5";
        }
        private void buttonSix_Click(object sender, EventArgs e)
        {
            string operation = labelOperation.Text;
            if (!operation.Contains("=")) labelOperation.Text += "6";
        }
        private void buttonSeven_Click(object sender, EventArgs e)
        {
            string operation = labelOperation.Text;
            if (!operation.Contains("=")) labelOperation.Text += "7";
        }
        private void buttonEight_Click(object sender, EventArgs e)
        {
            string operation = labelOperation.Text;
            if (!operation.Contains("=")) labelOperation.Text += "8";
        }
        private void buttonNine_Click(object sender, EventArgs e)
        {
            string operation = labelOperation.Text;
            if (!operation.Contains("=")) labelOperation.Text += "9";
        }
        
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            string operation = labelOperation.Text;
            if (usedOperator != null && !operation.EndsWith(usedOperator) && !operation.Contains("="))
            {
                int usedOperatorIndex = operation.IndexOf(usedOperator);
                double firstNumber = Convert.ToDouble(operation.Substring(0, usedOperatorIndex));
                double secondNumber = Convert.ToDouble(operation.Substring(usedOperatorIndex + 1));
                double result = 0;
                switch (usedOperator)
                {
                    case "+": result = firstNumber + secondNumber; break;
                    case "-": result = firstNumber - secondNumber; break;
                    case "×": result = firstNumber * secondNumber; break;
                    case "÷": result = firstNumber / secondNumber; break;
                    case "%": result = firstNumber % secondNumber; break;
                }
                labelOperation.Text += "=" + result;
            }
        }

    }
}
