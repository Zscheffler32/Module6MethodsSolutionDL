using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module6MethodsProjectDL
{
    public partial class frmMethodActing : Form
    {
        // Public Contsants to use
        const byte ADD = 0;
        const byte SUBTRACT = 1;
        const byte MULTIPLY = 2;
        const byte DIVIDE = 3;
        const byte MODULUS = 4;

        public frmMethodActing()
        {
            InitializeComponent();
        }

        public int methodMathematics(decimal operand1, decimal operand2, byte operation)
        {
            int result = 0;

            switch (operation)
            {
                case ADD:
                    result = (int)(operand1 + operand2);
                    break;
                    case SUBTRACT:
                    result = (int)(operand1 - operand2);
                    break;
                    case MULTIPLY:
                    result = (int)(operand1 * operand2);
                    break;
                    case DIVIDE:
                    result = (int)(operand1 / operand2);
                    break;
                    case MODULUS:
                    result = (int)(operand1 % operand2);
                    break;
            }

            return result;
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            decimal operand1 = decimal.Parse(txtbxLeft.Text);
            decimal operand2 = decimal.Parse(txtbxRight.Text);
            byte operation = MODULUS;

            int result = methodMathematics(operand1, operand2, operation);

            lblAnswer.Text = $"{operand1} % {operand2} = {result}";

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            decimal operand1 = decimal.Parse(txtbxLeft.Text);
            decimal operand2 = decimal.Parse(txtbxRight.Text);
            byte operation = DIVIDE;

            int result = methodMathematics(operand1, operand2, operation);

            lblAnswer.Text = $"{operand1} / {operand2} = {result}";

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            decimal operand1 = decimal.Parse(txtbxLeft.Text);
            decimal operand2 = decimal.Parse(txtbxRight.Text);
            byte operation = MULTIPLY;

            int result = methodMathematics(operand1, operand2, operation);

            lblAnswer.Text = $"{operand1} * {operand2} = {result}";

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            decimal operand1 = decimal.Parse(txtbxLeft.Text);
            decimal operand2 = decimal.Parse(txtbxRight.Text);
            byte operation = SUBTRACT;

            int result = methodMathematics(operand1, operand2, operation);

            lblAnswer.Text = $"{operand1} - {operand2} = {result}";

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            decimal operand1 = decimal.Parse(txtbxLeft.Text);
            decimal operand2 = decimal.Parse(txtbxRight.Text);
            byte operation = ADD;

            int result = methodMathematics(operand1, operand2, operation);

            lblAnswer.Text = $"{operand1} + {operand2} = {result}";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbxLeft.Text = "";
            txtbxRight.Text = "";
            lblAnswer.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
