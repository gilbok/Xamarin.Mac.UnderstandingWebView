// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace UnderstandingWebViewFinishedLoad
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		WebKit.WebView MyWebView { get; set; }

		[Outlet]
		AppKit.NSTextField UrlTextField { get; set; }

		[Action ("GoButton_Click:")]
		partial void GoButton_Click (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (UrlTextField != null) {
				UrlTextField.Dispose ();
				UrlTextField = null;
			}

			if (MyWebView != null) {
				MyWebView.Dispose ();
				MyWebView = null;
			}
		}
	}
}
