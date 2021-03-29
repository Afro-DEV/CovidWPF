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


namespace CovidWPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public List<Country> countries = new List<Country>();
		public Country France;
		public Country Britain;
		public Country Spain;
		public Country Germany;
		public Country Italy;
		
		public MainWindow()
		{
			InitializeComponent();
			//Country Britain;
		
			countries.Add(Britain = new Country { Name = "Britain", Deaths = 70195, Cases = 2200000});
			countries.Add(France = new Country { Name = "France", Deaths = 62573, Cases = 2500000});
			countries.Add(Spain = new Country { Name = "Spain", Deaths = 49824, Cases =  1869610});
			countries.Add(Germany = new Country { Name = "Germany", Deaths = 30157, Cases = 1643169 });
			countries.Add(Italy = new Country { Name = "Italy", Deaths = 71260, Cases = 2038759 });


			countryList.ItemsSource = countries;

		}

		

		public void checkButton_Click(object sender, RoutedEventArgs e)
		{
			var selectedCountry = (Country)countryList.SelectedItem;

		


			if (selectedCountry.Name == "Britain")
			{
				MessageBox.Show($"Cases:{ Britain.Cases.ToString()} " + $"Deaths:{Britain.Deaths.ToString()}", "Britain");
			}
			

			else if (selectedCountry.Name == "France")
			{
				MessageBox.Show($"Cases:{France.Cases.ToString()} " + $"Deaths:{France.Deaths.ToString()}", "France");
			}

			else if (selectedCountry.Name == "Spain")
			{
				MessageBox.Show($"Cases:{Spain.Cases.ToString()} " + $"Deaths:{Spain.Deaths.ToString()}", "Spain");
			}

			else if (selectedCountry.Name == "Germany")
			{
				MessageBox.Show($"Cases:{Germany.Cases.ToString()} " + $"Deaths:{Germany.Deaths.ToString()}", "Germany");
			}

			else if (selectedCountry.Name == "Italy")
			{
				MessageBox.Show($"Cases:{Italy.Cases.ToString()} " + $"Deaths:{Italy.Deaths.ToString()}", "Italy");
			}
			

			





		}

		public class Country
		{
			public string Name { get; set; }
			public int Cases { get; set; }
			public int Deaths { get; set; }
		}
	}
}
