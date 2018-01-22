// App.xaml.cs
// 
using System;
using System.Collections.Generic;
using TemFraldaBarata.Core.Features.Navigation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TemFraldaBarata.Core
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
			BuildDependencies();
			InitNavigation();
		}

		public void BuildDependencies()
		{
			ViewModelLocator.Instance.Build();
		}

		private async void InitNavigation()
		{
			var navigationService = ViewModelLocator.Instance.Resolve<INavigationService>();
			await navigationService.InitializeAsync();
		}

		protected override void OnStart()
		{
		}
	}
}
