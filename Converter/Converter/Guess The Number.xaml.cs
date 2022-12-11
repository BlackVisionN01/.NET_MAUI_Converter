namespace Converter;

public partial class GuessTheNumber : ContentPage
{
    readonly Random rnd;
    int guessnumar;
    string newText;
	public GuessTheNumber()
	{
		InitializeComponent();
        //Creare numar aleatoriu
        rnd = new Random();
        guessnumar = rnd.Next(1, 101);
    }

    //functii pt a lua valori din entry
    void OnEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        newText = e.NewTextValue;
    }

    void OnEntryCompleted(object sender, EventArgs e)
    {
        newText = ((Entry)sender).Text;
    }

    //functie caz pozitiv
    void Correct(object sender, EventArgs e)
    {
        GuessButton.Text = "Guess";
        Guess.Text = $"";
        ShowNumber.Text = $"";
        GuessButton.Clicked -= Correct;
        guessnumar = rnd.Next(1, 101);
        GuessButton.Clicked += GuessButtonClicked;
    }

    //functie buton
    void GuessButtonClicked(object sender, EventArgs e)
    {
        
        int numar = Convert.ToInt32(newText);
        ShowNumber.Text = $"You type {numar}";
        if (numar == guessnumar)
        {
            Guess.Text = $"Correct";
            GuessButton.Text = $"Replay!";
            GuessButton.Clicked += Correct;
            GuessButton.Clicked -= GuessButtonClicked;
        }
        else if (numar > guessnumar)
        {
            Guess.Text = $"Try a lower number";
        }
        else if (numar < guessnumar)
        {
            Guess.Text = $"Try a higher number";
        }
        GuessNumber.Text = "";
    }
}