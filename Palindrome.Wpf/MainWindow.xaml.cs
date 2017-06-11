using System;
using System.Linq;
using System.Windows;
using Palindrome.Library.Abstractions;
using Palindrome.Library.Implementations;

namespace Palindrome.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// FindTheThreeLongestPalinDromes_ButtonClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindTheThreeLongestPalinDromes_ButtonClick(object sender, RoutedEventArgs e)
        {
            ResetUI();

            try
            {
                IPalindromeLibrary library = new PalindromeLibrary();

                const int numberOfLongestPalindromes = 3;
             
                var listOfLongestPalindromes = library.FindNthLongestPalindromes(InputStringTextBox.Text, numberOfLongestPalindromes).ToList();

                PalindromeDataGrid.ItemsSource = listOfLongestPalindromes;

                CountLabel.Content = $"{listOfLongestPalindromes.Count} unique Palindrome(s) returned.";

            }
            catch (Exception exception)
            {
                CountLabel.Content = $"Error: {exception.Message} ";
                Console.WriteLine(exception);
            }
          
        }

        /// <summary>
        /// ResetUI
        /// </summary>
        private void ResetUI()
        {
            PalindromeDataGrid.ItemsSource = null;
            CountLabel.Content = string.Empty;
        }
    }
}
