using System;
using AppKit;
using Foundation;

/*Дан список, содержащий числовые данные. Отсортировать его по возрастанию
 и сформировать два новых списка таким образом, чтобы половина элементов 
 исходного списка попала в первый новый список (1, 3, 5, …), 
 а вторая половина – во второй новый (2, 4, 6, …).*/

namespace LRTest
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
        }

        public override NSObject RepresentedObject
        {
            get { return base.RepresentedObject; }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

    }
}