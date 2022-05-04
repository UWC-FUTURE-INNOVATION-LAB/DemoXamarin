using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoXamarin
{
    public partial class MainPage : ContentPage
    {
        private int _numberClicked;


        public MainPage()
        {
            InitializeComponent();

            CoolSlider.ValueChanged += OnSliderValueChanged;
        }

        private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            ClickCountLabel.Text = e.NewValue.ToString();

            ClickCountLabel.Rotation = e.NewValue;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            _numberClicked++;

            ClickCountLabel.Text = _numberClicked.ToString(); 

        }

        private void Xappiness_Clicked(object sender, EventArgs e)
        {
            // show xappiness

            Navigation.PushAsync(new XappinessPage());
        }
    }
}
