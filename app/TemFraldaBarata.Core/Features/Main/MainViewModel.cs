// MainViewModel.cs
// 
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace TemFraldaBarata.Core.Features.Main
{
	public class MainViewModel : ViewModelBase
	{
		public MainViewModel()
		{
			Title = "Tem Fralda Barata";
		}

		public ICommand SettingsCommand
			=> new Command(ExecuteSettingsCommand);

		async void ExecuteSettingsCommand()
			=> await NavigationService.NavigateToAsync<Settings.SettingsViewModel>();

	}
}
