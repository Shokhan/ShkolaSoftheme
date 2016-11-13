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

namespace LibraryWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        enum SearchCriteria { All, Genre, Price }
        private BookStore _store = new BookStore();
        public MainWindow()
        {
            InitializeComponent();

            List<string> options = new List<string>();
            options.Add("Все");
            options.Add("Жанр");
            options.Add("Цена");
            options.Add("Автор");

            searchOptions.ItemsSource = options;
            searchOptions.SelectedIndex = 0;
            searchCriteria.IsReadOnly = true;
            display.IsReadOnly = true;
        }

        private void show_Click(object sender, RoutedEventArgs e)
        {
            List<Book> books = _store.GetBooks((BookStore.SearchCriteria)searchOptions.SelectedIndex, searchCriteria.Text);

 
            string output = string.Empty;
            foreach (var book in books)
            {
                output += "Name: " + book.Name + "\nGenre: " + 
                    book.Genre + "\nAuthor: " + book.Author 
                    + "\n" + "Description: " + book.Description
                    + "\nPrice: " + book.Price + "\n\n";
            }

            if (output == string.Empty)
                output = "No results";

            display.Text = output;
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Book b = new Book
            {
                Name = name.Text,
                Genre = genre.Text,
                Price = price.Text,
                Description = description.Text
            };

            if(b.Price.OnlyDigits())
            {
                _store.AddBook(b);
                MessageBox.Show("Successful");
            }
            else
            {
                MessageBox.Show("Price is not valid.");
            }
        }

        private void searchOptions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (searchOptions.SelectedIndex == 0)
            {
                searchCriteria.IsReadOnly = true;
                searchCriteria.Text = string.Empty;
            }
            else
                searchCriteria.IsReadOnly = false;
        }
    }
}
