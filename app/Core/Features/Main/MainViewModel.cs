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
		DiapersViewModel _diapersViewModel;
		SettingsViewModel _settingsViewModel;
		OthersViewModel _othersViewModel;

		public DiapersViewModel DiapersViewModel
		{
			get
			{
				return _diapersViewModel;
			}
			set
			{
				_diapersViewModel = value;
				OnPropertyChanged();
			}
		}

		public OthersViewModel OthersViewModel
		{
			get
			{
				return _othersViewModel;
			}
			set
			{
				_othersViewModel = value;
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

		public MainViewModel(DiapersViewModel diapersViewModel,
							 SettingsViewModel settingsViewModel,
							 OthersViewModel othersViewModel)
		{
			_diapersViewModel = diapersViewModel;
			_settingsViewModel = settingsViewModel;
			_othersViewModel = othersViewModel;
		}
	}
}
