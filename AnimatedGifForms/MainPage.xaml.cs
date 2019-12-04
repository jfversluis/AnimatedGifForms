using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace AnimatedGifForms
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public bool IsPlaying { get; set; }

        public MainPage()
        {
            InitializeComponent();

            BindingContext = this;
        }

        void Button_Clicked(object sender, EventArgs e)
        {
            IsPlaying = !IsPlaying;
            OnPropertyChanged(nameof(IsPlaying));
        }
    }
}