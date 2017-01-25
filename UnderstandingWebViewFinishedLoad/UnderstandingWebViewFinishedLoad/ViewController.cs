using System;
using System.Diagnostics;
using AppKit;
using Foundation;

namespace UnderstandingWebViewFinishedLoad
{
	public partial class ViewController : NSViewController
	{
		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Do any additional setup after loading the view.
			MyWebView.FinishedLoad += (sender, e) =>
			{
				var url = e.ForFrame.DataSource.Request.Url;
				Debug.WriteLine(url);
			};
		}

		public override NSObject RepresentedObject
		{
			get
			{
				return base.RepresentedObject;
			}
			set
			{
				base.RepresentedObject = value;
				// Update the view, if already loaded.
			}
		}

		partial void GoButton_Click(Foundation.NSObject sender)
		{
			var url = UrlTextField.StringValue;
			if (string.IsNullOrEmpty(url) == true)
				return;

			MyWebView.MainFrame.LoadRequest(NSUrlRequest.FromUrl(NSUrl.FromString(url)));
		}
	}
}
