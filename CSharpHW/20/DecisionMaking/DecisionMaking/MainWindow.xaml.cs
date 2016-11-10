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

            User user = new User();
            user.FirstName = name.Text;
            user.LstName = lastName.Text;
            user.Day = day.Text;
            user.Month = month.Text;
            user.Year = year.Text;
            user.PhoneNumber = phoneNum.Text;
            user.Sex = gender.Text;
            user.additionalInfo = addInfo.Text;
            user.Email = email.Text;
            var results = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
            var context = new ValidationContext(user);
            var errors = Validator.Validate(user); 

            foreach(var err in errors)
            {
                wrongInput += err + "\n";
            }

            return wrongInput;
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            string wrongInput = validateForm();

            if (wrongInput == "")
            {
                if (MessageBox.Show("Registration successfull.") == MessageBoxResult.OK)
                    Environment.Exit(0);
                //finish prog
            }
            else
                MessageBox.Show(wrongInput);
        }

  
    }
}
