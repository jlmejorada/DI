namespace Maui
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"le has dado {count} caricias";
            else
                CounterBtn.Text = $"le has dado {count} caricias";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
