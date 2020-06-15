using PersonRepository.CSV;
using PersonRepository.Interface;
using PersonRepository.Service;
using PersonRepository.SQL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PeopleViewer
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
		IPersonRepository repository;
		
		public MainPage()
        {
            this.InitializeComponent();
        }

		private void ServiceFetchButton_Click(object sender, RoutedEventArgs e)
		{
			FetchData("Service");
		}

		private void CSVFetchButton_Click(object sender, RoutedEventArgs e)
		{
			FetchData("CSV");
		}

		private void SQLFetchButton_Click(object sender, RoutedEventArgs e)
		{
			FetchData("SQL");
		}

		private void FetchData(string repositoryType)
		{
			ClearListBox();

			switch (repositoryType)
			{
				case "Service": repository = new ServiceRepository();
					break;
				case "CSV": repository = new CSVRepository();
					break;
				case "SQL": repository = new SQLRepository();
					break;
				default:
					throw new ArgumentException("Invalid response type");
			}
			
			var people = repository.GetPeople(); //This shows the main adv of interface without which we would have to write this statement 4 times.
			foreach (var person in people)
				PersonListBox.Items.Add(person);
		}

		private void ClearButton_Click(object sender, RoutedEventArgs e)
		{
			ClearListBox();
		}

		private void ClearListBox()
		{
			PersonListBox.Items.Clear();
		}
	}
}
