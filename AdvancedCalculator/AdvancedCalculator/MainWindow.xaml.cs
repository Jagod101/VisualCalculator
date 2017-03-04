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

namespace AdvancedCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        String currentNum = "";
        String decimalNum = "";
        double first = 0;
        double angleNum;
        double sqrNum;
        bool second = false;
        bool multi = false;
        bool divide = false;
        bool add = false;
        bool subtract = false;
        bool func_cos = false;
        bool func_sin = false;
        bool func_tan = false;
        bool func_sqrt = false;
        bool squared = false;

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            currentNum += "1";

            if (!second)
            {
                text1.Text = currentNum;
            }
            else
            {
                text3.Text = currentNum;
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            currentNum += "2";

            if (!second)
            {
                text1.Text = currentNum;
            }
            else
            {
                text3.Text = currentNum;
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            currentNum += "3";

            if (!second)
            {
                text1.Text = currentNum;
            }
            else
            {
                text3.Text = currentNum;
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            currentNum += "4";

            if (!second)
            {
                text1.Text = currentNum;
            }
            else
            {
                text3.Text = currentNum;
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            currentNum += "5";

            if (!second)
            {
                text1.Text = currentNum;
            }
            else
            {
                text3.Text = currentNum;
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            currentNum += "6";

            if (!second)
            {
                text1.Text = currentNum;
            }
            else
            {
                text3.Text = currentNum;
            }
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            currentNum += "7";

            if (!second)
            {
                text1.Text = currentNum;
            }
            else
            {
                text3.Text = currentNum;
            }
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            currentNum += "8";

            if (!second)
            {
                text1.Text = currentNum;
            }
            else
            {
                text3.Text = currentNum;
            }
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            currentNum += "9";

            if (!second)
            {
                text1.Text = currentNum;
            }
            else
            {
                text3.Text = currentNum;
            }
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            currentNum += "0";

            if (!second)
            {
                text1.Text = currentNum;
            }
            else
            {
                text3.Text = currentNum;
            }
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            first = double.Parse(currentNum);
            multi = true;
            second = true;
            currentNum = "";
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            first = double.Parse(currentNum);
            divide = true;
            second = true;
            currentNum = "";
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            first = double.Parse(currentNum);
            add = true;
            second = true;
            currentNum = "";
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            first = double.Parse(currentNum);
            subtract = true;
            second = true;
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            if (multi == true)
            {
                double answer = first * double.Parse(currentNum);
                text2.Text = answer.ToString();
            }

            else if (divide == true)
            {
                double answer = first / double.Parse(currentNum);
                text2.Text = answer.ToString();
            }

            else if (add == true)
            {
                double answer = first + double.Parse(currentNum);
                text2.Text = answer.ToString();
            }

            else if (subtract == true)
            {
                double answer = first - double.Parse(currentNum);
                text2.Text = answer.ToString();
            }

            else if (func_cos == true)
            {
                double answer = Math.Cos(angleNum);
                text2.Text = answer.ToString();
            }

            else if (func_sin == true)
            {
                double answer = Math.Sin(angleNum);
                text2.Text = answer.ToString();
            }

            else if (func_tan == true)
            {
                double answer = Math.Tan(angleNum);
                text2.Text = answer.ToString();
            }

            else if (func_sqrt == true)
            {
                double answer = Math.Sqrt(sqrNum);
                text2.Text = answer.ToString();
            }

            else if (squared == true)
            {
                double answer = Math.Pow(sqrNum, 2);
                text2.Text = answer.ToString();
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            multi = false;
            divide = false;
            add = false;
            subtract = false;

            text1.Clear();
            text2.Clear();
            text3.Clear();

            currentNum = "";
            first = 0;
            second = false;

            func_cos = false;
            func_sin = false;
            func_tan = false;
            func_sqrt = false;
            squared = false;
        }

        private void leftParen_Click(object sender, RoutedEventArgs e)
        {
            currentNum = "(";
        }

        private void rightParen_Click(object sender, RoutedEventArgs e)
        {
            currentNum = ")";
        }

        private void _decimal_Click(object sender, RoutedEventArgs e)
        {
            decimalNum = ".";
            if (!second)
            {
                text1.Text = currentNum + decimalNum;
            }
            else
                text3.Text = currentNum;
        }

        private void positiveNegative_Click(object sender, RoutedEventArgs e)
        {
            currentNum = "-";
        }

        private void Square_Click(object sender, RoutedEventArgs e)
        {
            //currentNum = "sqr(";
            text1.Text = currentNum;

            sqrNum = double.Parse(currentNum);
            squared = true;
        }

        private void Sqrt_Click(object sender, RoutedEventArgs e)
        {
            //currentNum = "sqrt(";
            text1.Text = currentNum;

            sqrNum = double.Parse(currentNum);
            func_sqrt = true;
        }

        private void tangent_Click(object sender, RoutedEventArgs e)
        {
            //currentNum = "tan(";
            text1.Text = currentNum;

            angleNum = double.Parse(currentNum);
            func_tan = true;
        }

        private void sine_Click(object sender, RoutedEventArgs e)
        {
            //currentNum = "sin(";
            text1.Text = currentNum;

            angleNum = double.Parse(currentNum);
            func_sin = true;
        }

        private void cosine_Click(object sender, RoutedEventArgs e)
        {
            //currentNum = "cos";
            text1.Text = currentNum;

            angleNum = double.Parse(currentNum);
            func_cos = true;                
        }
    }
}
