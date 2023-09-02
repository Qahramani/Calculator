using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private char _operation;
        private bool _isScreenCleaned;
        private int _firstNumber;
        
            
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void number1Button_Click(object sender, EventArgs e)
        {
            if (_isScreenCleaned)
            {
                screenLabel.Text = "";
                _isScreenCleaned = false;
            }
            if(screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "1";
        }

        private void number2Button_Click(object sender, EventArgs e)
        {
            if (_isScreenCleaned)
            {
                screenLabel.Text = "";
                _isScreenCleaned = false;
            }
            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "2";
        }

        private void number3Button_Click(object sender, EventArgs e)
        {
            if (_isScreenCleaned)
            {
                screenLabel.Text = "";
                _isScreenCleaned = false;
            }
            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "3";
        }

        private void number4Button_Click(object sender, EventArgs e)
        {
            if (_isScreenCleaned)
            {
                screenLabel.Text = "";
                _isScreenCleaned = false;
            }
            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "4";
        }

        private void number5Button_Click(object sender, EventArgs e)
        {
            if (_isScreenCleaned) screenLabel.Text = "";
            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "5";
        }

        private void number6Button_Click(object sender, EventArgs e)
        {
            if (_isScreenCleaned)
            {
                screenLabel.Text = "";
                _isScreenCleaned = false;
            }
            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "6";
        }

        private void number7Button_Click(object sender, EventArgs e)
        {
            if (_isScreenCleaned)
            {
                screenLabel.Text = "";
                _isScreenCleaned = false;
            }
            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "7";
        }

        private void number8Button_Click(object sender, EventArgs e)
        {
            if (_isScreenCleaned)
            {
                screenLabel.Text = "";
                _isScreenCleaned = false;
            }
            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "8";
        }

        private void number9Button_Click(object sender, EventArgs e)
        {
            if (_isScreenCleaned)
            {
                screenLabel.Text = "";
                _isScreenCleaned = false;
            }
            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "9";
        }

        private void number0Button_Click(object sender, EventArgs e)
        {
            if (_isScreenCleaned)
            {
                screenLabel.Text = "";
                _isScreenCleaned = false;
            }
            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "0";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            _operation = '+';
            _isScreenCleaned = true;
            _firstNumber = Convert.ToInt32(screenLabel.Text);
        }

        

        private void minusButton_Click(object sender, EventArgs e)
        {
            _operation = '-';
            _isScreenCleaned = true;
            _firstNumber = Convert.ToInt32(screenLabel.Text);
        }

        private void multipleButton_Click(object sender, EventArgs e)
        {
            _operation = '*';
            _isScreenCleaned = true;
            _firstNumber = Convert.ToInt32(screenLabel.Text);
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            _operation = '/';
            _isScreenCleaned = true;
            _firstNumber = Convert.ToInt32(screenLabel.Text);
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            int _secondNumber = Convert.ToInt32(screenLabel.Text);
            int result;
            switch (_operation)
            {
                case '+':
                    result = _firstNumber + _secondNumber;
                    break;
                case '-':
                    result = _firstNumber - _secondNumber;
                    break;
                case '*':
                    result = _firstNumber * _secondNumber;
                    break;
                case '/':
                    result = _firstNumber / _secondNumber;
                    break;

                default:
                    result = 0;
                    break;
            }


            screenLabel.Text = Convert.ToString(result);

        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            screenLabel.Text = "0";
        }
    }
}
