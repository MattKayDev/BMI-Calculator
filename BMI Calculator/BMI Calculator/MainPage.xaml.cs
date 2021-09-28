using Xamarin.Forms;

namespace BMI_Calculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

        private void heightText_TextChanged(object sender, TextChangedEventArgs e)
        {
            //if (heightText.Text == "")
            //    HeightSlider.Value = HeightSlider.Minimum;
            //else
            //    HeightSlider.Value = Convert.ToInt32(heightText.Text);
        }

        private void weightText_TextChanged(object sender, TextChangedEventArgs e)
        {
            //if (weightText.Text == "")
            //    WeightSlider.Value = WeightSlider.Minimum;
            //else
            //    WeightSlider.Value = Convert.ToInt32(weightText.Text);

        }

       
    }
}
