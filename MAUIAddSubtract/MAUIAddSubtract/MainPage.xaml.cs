namespace MAUIAddSubtract
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnAdditionClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FirstValueEntry.Text) ||
                string.IsNullOrWhiteSpace(SecondValueEntry.Text))
            {
                MessageLabel.Text = "Please enter values for both fields to get the sum";
                return;
            }

            if (double.TryParse(FirstValueEntry.Text, out double firstValue) &&
                double.TryParse(SecondValueEntry.Text, out double secondValue))
            {
                MessageLabel.Text = "";

                await Navigation.PushAsync(
                    new ResultPage(firstValue, secondValue, "Addition"));
            }
        }

        private async void OnSubtractionClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FirstValueEntry.Text) ||
                string.IsNullOrWhiteSpace(SecondValueEntry.Text))
            {
                MessageLabel.Text = "Please enter values for both fields to get the difference";
                return;
            }

            if (double.TryParse(FirstValueEntry.Text, out double firstValue) &&
                double.TryParse(SecondValueEntry.Text, out double secondValue))
            {
                MessageLabel.Text = "";

                await Navigation.PushAsync(
                    new ResultPage(firstValue, secondValue, "Subtraction"));
            }
        }
    }
}
