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

namespace DecisionMaking
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

        public string validateForm()
        {
            string wrongInput = "";

            //Name field
            if (name.Text.Length == 0)
                wrongInput += "Fill name field.\n";
            else
            {
                if (containNumbers(name.Text))
                    wrongInput += "Name should contain only letters.\n";
                if (name.Text.Length >= 255)
                    wrongInput += "Lenght of name may have lenght less than 255.\n";
            }

            //Last name field
            if (lastName.Text.Length == 0)
                wrongInput += "Fill last name field.\n";
            else
            {
                if (containNumbers(lastName.Text))
                    wrongInput += "Last name should contain only letters.\n";
                if (lastName.Text.Length >= 255)
                    wrongInput += "Lenght of last name may have lenght less than 255.\n";
            }

            //Birth date field
            if (day.Text.Length == 0 || year.Text.Length == 0 || month.Text.Length == 0)
                wrongInput += "Fill date field completely\n";
           else
            {
                if (containChar(day.Text) || containChar(month.Text) || containChar(year.Text))
                    wrongInput += "Date can be only a number.\n";
                else
                {
                    int num = int.Parse(day.Text);
                    if (num < 1 || num > 31)
                        wrongInput += "Incorrect day.\n";

                    num = int.Parse(month.Text);
                    if (num < 1 || num > 12)
                        wrongInput += "Incorrect month.\n";

                    num = int.Parse(year.Text);
                    if (num < 1900 || num > DateTime.Now.Year)
                        wrongInput += "Incorrect year.\n";
                }
            }

            //Gender 
            if (lastName.Text.Length == 0)
                wrongInput += "Fill gender field.\n";
            else if (gender.Text.ToLower() != "male" && gender.Text.ToLower() != "emale")
                wrongInput += "Incorrect gender input.\n";

            //Email field
            if (email.Text.Length == 0)
                wrongInput += "Fill email field.\n";
            else if (!email.Text.Contains("@") || email.Text.Length > 255)
                wrongInput += "Incorrect email.\n";

            //Phonenum field
            if (phoneNum.Text.Length == 0)
                wrongInput += "Fill phone number field.\n";
            else if (containChar(phoneNum.Text) || phoneNum.Text.Length != 12)
                    wrongInput += "Incorrect phone number.\n";

            if (addInfo.Text.Length > 2000)
                wrongInput += "Additional info may contain less than 2000 characters.\n";
            return wrongInput;
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            string wrongInput = validateForm();

            if (wrongInput == "")
            {
                if(MessageBox.Show("Registration successfull.") == MessageBoxResult.OK)
                    Environment.Exit(0);
                //finish prog
            }
            else
                MessageBox.Show(wrongInput);
        }

        public bool containNumbers(string str)
        {
            int size = str.Length;
            for (int i = 0; i < size; ++i)
                if (char.IsDigit(str[i]))
                    return true;
            return false;
        }

        public bool containChar(string str)
        {
            int size = str.Length;
            for (int i = 0; i < size; ++i)
                if (char.IsLetter(str[i]))
                    return true;
            return false;
        }
    }
}
