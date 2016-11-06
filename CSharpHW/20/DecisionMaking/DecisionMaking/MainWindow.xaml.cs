using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            string wrongInput = string.Empty;

            if (containChar(day.Text) || containChar(month.Text) || containChar(year.Text))
                wrongInput += "Date can be only a number.\n";
            else
            {
                if (containNumbers(name.Text))
                    wrongInput += "Name should contain only letters.\n";

                if (containNumbers(lastName.Text))
                    wrongInput += "Last name should contain only letters.\n";

                if (gender.Text.ToLower() != "male" && gender.Text.ToLower() != "emale")
                    wrongInput += "Incorrect gender input.\n";

                if (!email.Text.Contains("@"))
                    wrongInput += "Email does not contain @.\n";

                if(wrongInput == string.Empty)
                {
                    User user = new User();
                    user.FirstName = name.Text;
                    user.LstName = lastName.Text;
                    user.Day = int.Parse(day.Text);
                    user.Month = int.Parse(month.Text);
                    user.Year = int.Parse(year.Text);
                    user.PhoneNumber = phoneNum.Text;
                    user.Sex = gender.Text;
                    user.additionalInfo = addInfo.Text;

                    var results = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
                    var context = new ValidationContext(user);
                    if (!Validator.TryValidateObject(user, context, results))
                    {
                        foreach (var error in results)
                            wrongInput += error.ErrorMessage + '\n';
                    }
                }
            }

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
