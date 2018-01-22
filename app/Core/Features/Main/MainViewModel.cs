// MainViewModel.cs
// 
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace TemFraldaBarata.Core.Features
{
	public class MainViewModel : ViewModelBase
	{
		FeedViewModel _feedViewModel;
		SettingsViewModel _settingsViewModel;

		public FeedViewModel FeedViewModel
		{
			get
			{
				return _feedViewModel;
			}

			set
			{
				_feedViewModel = value;
				OnPropertyChanged();
			}
		}

		public SettingsViewModel SettingsViewModel
		{
			get
			{
				return _settingsViewModel;
			}

			set
			{
				_settingsViewModel = value;
				OnPropertyChanged();
			}
		}

		public MainViewModel(FeedViewModel feedViewModel,
							 SettingsViewModel settingsViewModel)
		{
			_feedViewModel = feedViewModel;
			_settingsViewModel = settingsViewModel;
		}

		//public override Task InitializeAsync(object navigationData)
		//{
		//	return Task.WhenAll
		//		(
		//			NavigationService.NavigateToAsync<FeedViewModel>(navigationData)
		//		);
		//}
	}
}
