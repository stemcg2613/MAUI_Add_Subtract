namespace MAUIAddSubtract
{
    public partial class ResultPage : ContentPage
    {
        public ResultPage(double firstNumber, double secondNumber, string operation)
        {
            InitializeComponent();

            NumbersLabel.Text = $"The numbers entered are: {firstNumber} and {secondNumber}.";

            if (operation == "Addition")
            {
                double sum = firstNumber + secondNumber;
                ResultLabel.Text = $"The sum of the numbers is {sum}.";
            }
            else if (operation == "Subtraction")
            {
                double difference = firstNumber - secondNumber;
                ResultLabel.Text = $"The difference of the numbers is {difference}.";
            }
        }

        private async void OnGoBackClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
