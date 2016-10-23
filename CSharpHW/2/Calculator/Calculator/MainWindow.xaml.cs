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

namespace Calculator
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

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = "";
        }

    
        private void one_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "1";
        }
        private void two_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "2";
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "3";
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "4";
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "5";
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "6";
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "7";
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "8";
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "9";
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "0";
        }

        private void Display_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void point_Click(object sender, RoutedEventArgs e)
        {
            string str = Display.Text;
            bool is_possible_to_put = true;

            int size = str.Count();
            if (size == 0)
                return;

            for (int i = size - 1; i >= 0; --i)
            {
                if (str[i] == ',')
                {
                     is_possible_to_put = false;
                     break;
                }

                if (str[i] == '+' || str[i] == '-' ||
                    str[i] == '/' || str[i] == '*')
                    break;
            }

            if (is_possible_to_put)
                Display.Text += ',';
        }

        private bool is_last_char_sign()
        {
            string input = Display.Text;
            if (input.Length == 0)
                return false;

            int last = input.Length - 1;

            if (input[last] == '+' || input[last] == '-' ||
                    input[last] == '/' || input[last] == '*' || input[last] == ',')
                return true;

            return false;
        }
        private void add_Click(object sender, RoutedEventArgs e)
        {
            if(!is_last_char_sign())
                Display.Text += "+";
        }

        private void substract_Click(object sender, RoutedEventArgs e)
        {
            if (!is_last_char_sign())
                Display.Text += "-";
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            if (!is_last_char_sign())
                Display.Text += "*";
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            if (!is_last_char_sign())
                Display.Text += "/";
        }

        private void eq_Click(object sender, RoutedEventArgs e)
        {
            string input = Display.Text;
            Display.Text = string.Format("{0}", Calculate(input));
        }

        double Calculate(string input)
        {
            List<double> numbers = new List<double>();
            List<char> signs = new List<char>();
            //Отделение чисел и знаков
            string temp = "";
            int size = input.Length;
            for (int i = 0; i < size; ++i)
            {
                if (input[i] == '+' || input[i] == '-' ||
                    input[i] == '/' || input[i] == '*')
                {
                    signs.Add(input[i]);
                    numbers.Add(double.Parse(temp));
                    temp = "";
                }
                else
                    temp += input[i];
            }
            numbers.Add(double.Parse(temp));

            //Сначала проводим операции с большим приоритетом
            for (int i = 0; i < signs.Count;)
            {
                if (signs[i] == '*')
                {
                    numbers[i] *= numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    signs.RemoveAt(i);
                }
                else if (signs[i] == '/')
                {
                    numbers[i] /= numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    signs.RemoveAt(i);
                }
                else
                    ++i;
            }

            //Теперь все что осталось
            for (int i = 0; i < signs.Count;)
            {
                if (signs[i] == '-')
                    numbers[i] -= numbers[i + 1];
                else
                    numbers[i] += numbers[i + 1];
                numbers.RemoveAt(i + 1);
                signs.RemoveAt(i);
            }

            return numbers[0];
        }
    }
}
