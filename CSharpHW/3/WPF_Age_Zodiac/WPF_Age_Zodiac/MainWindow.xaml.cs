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

namespace WPF_Age_Zodiac
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string imagesPath;
        public MainWindow()
        {
            InitializeComponent();
            age.IsReadOnly = true;
            Zodiac.IsReadOnly = true;
            imagesPath = string.Format(@"{0}\Images\", Environment.CurrentDirectory);
        }

        private void Get_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AgeZodiacInfo info = new AgeZodiacInfo(input.Text);
                age.Text = info.GetAge().ToString();
                string z = info.determineZodiac();
                Zodiac.Text = z;
                string path = imagesPath + z + ".jpg";
                image.Source = new BitmapImage(new Uri(path));
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Incorrect input. Input correct date!!");
            }
        }
    }
}
