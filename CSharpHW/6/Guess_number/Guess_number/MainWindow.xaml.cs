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

namespace Guess_number
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                checkNum();
            }
            catch(FormatException format)
            {
                MessageBox.Show("Input should be only integer number.");
            }
            catch(ArgumentOutOfRangeException outofRange)
            {
                MessageBox.Show("Number can be from 1 to 10.");
            }
        }

        private void checkNum()
        {
            for (int i = 0; i < num.Text.Length; ++i)
                if (!char.IsNumber(num.Text[i]))
                    throw new FormatException();

            int n = int.Parse(num.Text);
            if (n < 1 || n > 10)
                throw new ArgumentOutOfRangeException();

            int r = random.Next(1, 11);
            if (r != n)
                MessageBox.Show(string.Format("Answer is wrong. Correct answer = {0}!!!", r.ToString()));
            else
                MessageBox.Show("You won!!!");
        }
    }
}
