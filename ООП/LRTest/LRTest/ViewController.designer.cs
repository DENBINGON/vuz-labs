// WARNING
//
// This file has been generated automatically by Rider IDE
//   to store outlets and actions made in Xcode.
// If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace LRTest
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSGridView qq { get; set; }

		[Action ("s:")]
		partial void s (AppKit.NSTextFieldCell sender);

		void ReleaseDesignerOutlets ()
		{
			if (qq != null) {
				qq.Dispose ();
				qq = null;
			}

		}
	}
}
