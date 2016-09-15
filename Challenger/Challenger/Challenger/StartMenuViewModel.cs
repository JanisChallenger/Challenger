using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Challenger
{
    class StartMenuViewModel : BaseViewModel
    {
        public Command PushMe { get; set; }

        public Button HURNBUTTON;

        string mt;
        public string MainText { get { return mt; } set { mt = value; OnPropertyChanged("MainText"); } }

        public StartMenuViewModel()
        {
            MainText = "Whoopie Goldberg is a jew";
            PushMe = new Command(() =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    if (HURNBUTTON != null)
                    {
                        HURNBUTTON.RotateTo(HURNBUTTON.Rotation + 180, 2000, Easing.BounceOut);
                    }
                });
            }
            );
        }
    }
}
