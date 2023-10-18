using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AuxiliaryLibraries;

namespace Calculator
{
    public partial class Caculator : Form
    {
        private List<decimal> history = new List<decimal>();
        private Operator Operator = Operator.None;
        private bool isNumberNewed = false, isDecimal = false;
        private bool isNegetive = false;
        public Caculator()
        {
            InitializeComponent();
        }
        private void Caculator_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        #region Basic Functions

        private void Plus()
        {
            AddResultToHistory();
            OperatorEqual();
            SetOperator(Operator.Plus);
        }

        private void Minus()
        {
            AddResultToHistory();
            OperatorEqual();
            SetOperator(Operator.Minus);
        }

        private void Multiply()
        {
            AddResultToHistory();
            OperatorEqual();
            SetOperator(Operator.Multiply);
        }

        private void Divide()
        {
            AddResultToHistory();
            OperatorEqual();
            SetOperator(Operator.Divide);
        }

        private void Equal(bool addToHistory = true)
        {
            if (addToHistory)
                AddResultToHistory();
            decimal number = history[0];
            for (int i = 1; i < history.Count; i++)
                switch (Operator)
                {
                    case Operator.Plus:
                        number += history[i];
                        break;
                    case Operator.Minus:
                        number -= history[i];
                        break;
                    case Operator.Multiply:
                        number *= history[i];
                        break;
                    case Operator.Divide:
                        number /= history[i];
                        break;
                }
            if (addToHistory)
                SetOperator(Operator.None);
            ClearHistory();
            AddToHistory(number, setAsResult: true);
        }

        private void SetOperator(Operator @operator)
        {
            Operator = @operator;
            switch (@operator)
            {
                case Operator.Plus:
                    labelOperator.Text = "+";
                    break;
                case Operator.Minus:
                    labelOperator.Text = "-";
                    break;
                case Operator.Multiply:
                    labelOperator.Text = "*";
                    break;
                case Operator.Divide:
                    labelOperator.Text = "/";
                    break;
                case Operator.None:
                default:
                    labelOperator.Text = string.Empty;
                    break;
            }
        }

        private void OperatorEqual()
        {
            if (history.Count > 1)
                Equal(addToHistory: false);
        }

        private void NumberAction(decimal number)
        {
            // این دستور به این خاطر است که زمانی که کاربر میخواد عدد وارد شده رو به علاوه ی یک عدد دیگه بکنه در این لحظه 0 رو نمایش بدهد و زمانی که عدد جدید رو وارد کرد 0 برداشته بشود
            if (isNumberNewed)
            {
                labelResult.Text = "0";
                isNumberNewed = false;
            }
            labelResult.Text = decimal.Parse($"{labelResult.Text}{number}").ToCommaDelimited();
        }

        private void SetDecimal()
        {
            if (!isDecimal)
            {
                labelResult.Text += ".";
                isDecimal = true;
            }
        }

        private void ClearResult(bool clearResult = true)
        {
            //این دستور برای این است که زمانی که نتیجه پاک میشود اولا 0 رو نمایش بده و ثانین دوباره اجازه بدهد که کاربر اعشار رو وارد کند در غیر این صورت اعشار بیش از یکبار اجازه استفاده ندارد
            if (clearResult)
                labelResult.Text = "0";
            isDecimal = false;
        }

        private void ClearHistory()
        {
            history.Clear();
            isDecimal = false;
        }

        private void ClearSelection()
        {
            // برای این است که زمانی که کاربر بر روی دکمه ای کلیک کرد و حالا دستش رو از کلیک برداشت روی ان دکمه در حالت کلیک نماند
            labelResult.Select();
        }

        private decimal GetNumberFromScreen()
        {
            return decimal.Parse(labelResult.Text);
        }

        private void AddResultToHistory()
        {
            if (!isNumberNewed)
            {
                AddToHistory(GetNumberFromScreen());
                ClearResult(clearResult: false);
            }
        }

        private void AddToHistory(decimal number, bool setAsResult = false)
        {
            history.Add(number);
            if (setAsResult)
                SetResult(number);
            isNumberNewed = true;
        }

        private void SetResult(decimal number)
        {
            labelResult.Text = number.ToString();
            if (number % 1 != 0) // چک می کنه آیا عدد اعشاری هست یا خیر
                isDecimal = true;
        }

        private void BackSpace()
        {
            string srtingNumber = labelResult.Text;
            srtingNumber = srtingNumber.Remove(srtingNumber.Length - 1);
            decimal.TryParse(srtingNumber, out var number);
            labelResult.Text = number.ToString();
            ClearSelection();
        }

        #endregion

        #region Events
        private void button_one_Click(object sender, EventArgs e)
        {
            NumberAction(1);
            ClearSelection();
        }

        private void button_two_Click(object sender, EventArgs e)
        {
            NumberAction(2);
            ClearSelection();
        }

        private void button_three_Click(object sender, EventArgs e)
        {
            NumberAction(3);
            ClearSelection();
        }

        private void button_four_Click(object sender, EventArgs e)
        {
            NumberAction(4);
            ClearSelection();
        }

        private void button_five_Click(object sender, EventArgs e)
        {
            NumberAction(5);
            ClearSelection();
        }

        private void button_Six_Click(object sender, EventArgs e)
        {
            NumberAction(6);
            ClearSelection();
        }

        private void button_Seven_Click(object sender, EventArgs e)
        {
            NumberAction(7);
            ClearSelection();
        }

        private void button_eight_Click(object sender, EventArgs e)
        {
            NumberAction(8);
            ClearSelection();
        }

        private void button_nin_Click(object sender, EventArgs e)
        {
            NumberAction(9);
            ClearSelection();
        }

        private void button_zero_Click(object sender, EventArgs e)
        {
            NumberAction(0);
            ClearSelection();
        }

        private void Caculator_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                    button_zero_Click(sender, e);
                    break;
                case Keys.NumPad1:
                    button_one_Click(sender, e);
                    break;
                case Keys.NumPad2:
                    button_two_Click(sender, e);
                    break;
                case Keys.NumPad3:
                    button_three_Click(sender, e);
                    break;
                case Keys.NumPad4:
                    button_four_Click(sender, e);
                    break;
                case Keys.NumPad5:
                    button_five_Click(sender, e);
                    break;
                case Keys.NumPad6:
                    button_Six_Click(sender, e);
                    break;
                case Keys.NumPad7:
                    button_Seven_Click(sender, e);
                    break;
                case Keys.NumPad8:
                    button_eight_Click(sender, e);
                    break;
                case Keys.NumPad9:
                    button_nin_Click(sender, e);
                    break;
                case Keys.Add:
                    button_sum_Click(sender, e);
                    break;
                case Keys.Subtract:
                    button_minus_Click(sender, e);
                    break;
                case Keys.Multiply:
                    button_multipli_Click(sender, e);
                    break;
                case Keys.Divide:
                    button_division_Click(sender, e);
                    break;
                case Keys.Back:
                    button_backspace_Click(sender, e);
                    break;
                case Keys.Decimal:
                    button_decimal_Click(sender, e);
                    break;
                case Keys.Escape:
                    button_claer_Click(sender, e);
                    break;
            }
        }

        private void button_sum_Click(object sender, EventArgs e)
        {
            Plus();
            ClearSelection();
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            Equal();
            ClearSelection();
        }

        private void Caculator_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                button_equal_Click(sender, e);
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            Minus();
            ClearSelection();
        }

        private void button_multipli_Click(object sender, EventArgs e)
        {
            Multiply();
            ClearSelection();
        }

        private void button_division_Click(object sender, EventArgs e)
        {
            Divide();
            ClearSelection();
        }

        private void button_claer_Click(object sender, EventArgs e)
        {
            ClearResult(clearResult: true);
            ClearHistory();
            SetOperator(Operator.None);
            ClearSelection();
        }

        private void button_claerentry_Click(object sender, EventArgs e)
        {
            ClearResult(clearResult: true);
            SetOperator(Operator.None);
            ClearSelection();
        }

        private void button_backspace_Click(object sender, EventArgs e)
        {
            BackSpace();
            ClearSelection();
        }

        private void button_negative_Click(object sender, EventArgs e)
        {
            labelResult.Text = Convert.ToString(decimal.Parse(labelResult.Text) * -1);
            isNegetive = !isNegetive;
            ClearSelection();
        }

        private void button_power_Click(object sender, EventArgs e)
        {
            var number = (double)GetNumberFromScreen();
            ClearHistory();
            AddToHistory((decimal)Math.Pow(number, 2), true);
            ClearSelection();
        }

        private void button_Root_Click(object sender, EventArgs e)
        {
            ClearHistory();
            AddToHistory((decimal)Math.Sqrt((double)GetNumberFromScreen()), true);
            ClearSelection();
        }

        private void button_inverse_Click(object sender, EventArgs e)
        {
            ClearHistory();
            var result = 1 / (GetNumberFromScreen());
            AddToHistory(result, true);
            ClearSelection();
        }

        private void button_percent_Click(object sender, EventArgs e)
        {
            var firstNumber = history[0];
            var secondNumber = GetNumberFromScreen();
            var result = (firstNumber / 100) * secondNumber;
            SetResult(result);
            ClearSelection();
        }

        private void button_decimal_Click(object sender, EventArgs e)
        {
            SetDecimal();
        }
        #endregion
    }
}
