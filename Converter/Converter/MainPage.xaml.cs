using static System.Net.Mime.MediaTypeNames;

namespace Converter;

public partial class MainPage : ContentPage
{
    string newText;

    public MainPage()
	{
		InitializeComponent();
	}
    //functii pt a lua valori din entry
    void OnEntryCompleted(object sender, EventArgs e)
    {
        newText = ((Entry)sender).Text;
    }

    void OnEntryTextChanged(object sender, TextChangedEventArgs e)
    {

        newText = e.NewTextValue;
    }

    //functie conversie euro in lei
    private void OnCounterClicked(object sender, EventArgs e)
	{
        float valoare = float.Parse(newText);
        float Euro = 4.93F;
        valoare = valoare * Euro;
        ConverterPlace.Text = $" {valoare.ToString("0.00")} lei";

		SemanticScreenReader.Announce(ConverterPlace.Text);
	}

    //functie schimbare pagina
    private void GoTo(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(GuessTheNumber));
    }
}

