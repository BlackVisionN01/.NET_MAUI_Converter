namespace Converter;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(GuessTheNumber), typeof(GuessTheNumber));
	}
}
