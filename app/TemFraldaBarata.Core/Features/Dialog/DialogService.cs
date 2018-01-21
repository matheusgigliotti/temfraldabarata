﻿// DialogService.cs
// 
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TemFraldaBarata.Core.Features.Dialog
{
	public class DialogService : IDialogService
	{
		protected Application CurrentApplication
		{
			get { return Application.Current; }
		}

		public async Task<string> ActionSheetAsync(string title, string cancel, string destruction, params string[] buttons)
		=> await CurrentApplication
				.MainPage.DisplayActionSheet(title, cancel, destruction, buttons);

		public async Task AlertAsync(string title, string message, string cancel)
		=> await CurrentApplication
				.MainPage.DisplayAlert(title, message, cancel);

		public async Task<bool> AlertAsync(string title, string message, string accept, string cancel)
		=> await CurrentApplication
				.MainPage.DisplayAlert(title, message, accept, cancel);
	}
}
