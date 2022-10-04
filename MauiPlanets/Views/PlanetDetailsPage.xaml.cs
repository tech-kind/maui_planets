namespace MauiPlanets.Views;

public partial class PlanetDetailsPage : ContentPage
{
	public PlanetDetailsPage(Planet planet)
	{
		InitializeComponent();

        BindingContext = planet;
	}

    private async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}