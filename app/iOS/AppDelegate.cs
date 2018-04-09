// AppDelegate.cs
// 
using Foundation;
using UIKit;
using TemFraldaBarata.Core;

namespace TemFraldaBarata.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			LoadApplication(new TemFraldaBarata.Core.App());

			return base.FinishedLaunching(app, options);
		}
	}
}
