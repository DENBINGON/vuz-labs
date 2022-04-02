// WARNING
//
// This file has been generated automatically by Rider IDE
//   to store outlets and actions made in Xcode.
// If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MacOSApp1
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSGridView grid { get; set; }

		[Outlet]
		AppKit.NSTextField lab { get; set; }

		[Action ("button:")]
		partial void button (AppKit.NSButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (lab != null) {
				lab.Dispose ();
				lab = null;
			}

			if (grid != null) {
				grid.Dispose ();
				grid = null;
			}

		}
	}
}
