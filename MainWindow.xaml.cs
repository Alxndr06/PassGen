using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
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

namespace PassGen
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

		// -----------------------------------------------------------------//

		bool usingMinCharacters = false;
		bool usingMajCharacters = false;
		bool usingNumbers = false;
		bool usingSpeCharacters = false;

		private void Button_Click_About(object sender, RoutedEventArgs e)
		{
			var about = new About();

			about.Show();
        }

		private void Button_Click_Quit(object sender, RoutedEventArgs e)
		{
			var buttons = MessageBoxButton.YesNo;
			var message = "Are you sure to want to quit the program ?";
			var title = "Leave to Windows";
			MessageBoxResult result = MessageBox.Show(message, title, buttons);

			if (result == MessageBoxResult.Yes)
			{
				Environment.Exit(0);
			}
		}

		private void Button_MinChars_Click(object sender, RoutedEventArgs e)
		{
			if (usingMinCharacters)
			{
				usingMinCharacters = false;
				MinCharsLabel.Content = "Désactivé";
				MinCharsLabel.Background = new SolidColorBrush(Colors.Red);
			}
			else
			{
				usingMinCharacters = true;
				MinCharsLabel.Content = "Activé";
				MinCharsLabel.Background = new SolidColorBrush(Colors.Green);
			}
		}

		private void Btutton_MajChars_Click(object sender, RoutedEventArgs e)
		{
			if (usingMajCharacters)
			{
				usingMajCharacters = false;
				MajCharsLabel.Content = "Désactivé";
				MajCharsLabel.Background = new SolidColorBrush(Colors.Red);
			}
			else
			{
				usingMajCharacters = true;
				MajCharsLabel.Content = "Activé";
				MajCharsLabel.Background = new SolidColorBrush(Colors.Green);
			}
		}

		private void numbersButton_Click(object sender, RoutedEventArgs e)
		{
			if (usingNumbers)
			{
				usingNumbers = false;
				numbersLabel.Content = "Désactivé";
				numbersLabel.Background = new SolidColorBrush(Colors.Red);
			}
			else
			{
				usingNumbers = true;
				numbersLabel.Content = "Activé";
				numbersLabel.Background = new SolidColorBrush(Colors.Green);
			}
		}

		private void charSpecsButton_Click(object sender, RoutedEventArgs e)
		{
			if (usingSpeCharacters)
			{
				usingSpeCharacters = false;
				speCharsLabel.Content = "Désactivé";
				speCharsLabel.Background = new SolidColorBrush(Colors.Red);
			}
			else
			{
				usingSpeCharacters = true;
				speCharsLabel.Content = "Activé";
				speCharsLabel.Background = new SolidColorBrush(Colors.Green);
			}
		}

		private void generateButton_Click(object sender, RoutedEventArgs e)
		{
			Passwords password = new Passwords();

			password.GeneratePassword(usingMinCharacters, usingMajCharacters, usingNumbers, usingSpeCharacters);
		}

		private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
		{

        }
    }
}