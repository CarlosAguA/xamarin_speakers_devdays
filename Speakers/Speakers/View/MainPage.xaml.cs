using Speakers.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Speakers
{
    public partial class MainPage : ContentPage
    {

        SpeakersViewModel vm;

        public MainPage()
        {
            InitializeComponent();

            // Create the view model and set as binding context
            vm = new SpeakersViewModel();
            BindingContext = vm;
        }
    }
}
