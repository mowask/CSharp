using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_Calc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private decimal num1, num2, result;
        private bool  isClearButton;
        private string currientOperation;
        public MainWindow()
        {
            InitializeComponent();
            SetupEvents();
            SetTextButton("0");

            num1= 0;
            num2= 0;
            result = 0;
            //isNum1Set= false;
            isClearButton = false;
            currientOperation = string.Empty;
        }

        private void SetupEvents()
        {
            List<Button> buttons = new List<Button>()
            {
                btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9
            };
            foreach (Button button in buttons)
            {
                button.Click += Button_Click;
            }

            List<Button> buttonsOperation = new List<Button>()
            {
                btnDivision, btnMultiplication, btnMinus, btnPlus
            };
            foreach (Button button in buttonsOperation)
            {
                button.Click += ButtonOperation_Click;
            }

            btnEqual.Click += BtnEqual_Click;
            btnDot.Click += BtnDot_Click;
        }

       

        private void SetTextButton(string text)
        {
            if (bottomInput.Text == "0")
                bottomInput.Text = text;
            else if (isClearButton)
            {
                bottomInput.Text = text;
                isClearButton= false;
            }
            else
                bottomInput.Text += text;
        }

        private void SetTextTop(string text)
        {            
                topInput.Text = text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {                       
                SetTextButton((string) (sender as Button).Content); 
        }

        private void ButtonOperation_Click(object sender, RoutedEventArgs e)
        {
            string operation = (string) (sender as Button).Content;
            if (currientOperation == string.Empty)
            {
                num1 = decimal.Parse(bottomInput.Text);             
                SetTextTop(bottomInput.Text + operation);
            }
            else
            {
                num2 = decimal.Parse(bottomInput.Text);
                result = doOperation(num1, num2, currientOperation);

                SetTextTop(result + operation);
                isClearButton = true;
                SetTextButton(result.ToString());
                
                num1 = result;               
            }
            currientOperation = operation;
            isClearButton = true;            
        }

        private void BtnEqual_Click(object sender, RoutedEventArgs e)
        {
            num2 = decimal.Parse(bottomInput.Text);
            result = doOperation(num1, num2, currientOperation);

            SetTextTop(topInput.Text + num2 + "=");
            isClearButton = true;
            SetTextButton(result.ToString());

            num1 = result;
            currientOperation = string.Empty;
            isClearButton = true;
        }

        private decimal doOperation (decimal n1, decimal n2, string op)
        {
            switch(op)
            {
                case "+":
                    return n1 + n2;
                case "-":
                    return n1 - n2;
                case "*":
                    return n1 * n2;
                case "/":
                    return n1 / n2;    
            }
            return 0;
        }

        private void BtnDot_Click(object sender, RoutedEventArgs e)
        {
            if (bottomInput.Text.Contains(",")) return;
            if (bottomInput.Text == "0")
            {
                SetTextButton("0,");
            }
            else SetTextButton(",");
        }



    }
}
