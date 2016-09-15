using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Challenger
{
    public partial class StartMenu : ContentPage
    {


        public StartMenu()
        {
            InitializeComponent();
            if (BindingContext != null)
            {
                ((StartMenuViewModel)this.BindingContext).HURNBUTTON = hurn;
            }
        }
    }
}
