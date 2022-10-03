namespace MauiPlanets.Views;

public partial class PlanetsPage : ContentPage
{
    private const uint AnimationDuration = 800u;

	public PlanetsPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        lstPopularPlanets.ItemsSource = PlanetsService.GetFeaturedPlanets();
        lstAllPlanets.ItemsSource = PlanetsService.GetAllPlanets();
    }

    private async void Planets_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }

    private async void GridArea_Tapped(object sender, EventArgs e)
    {
        await CloseMenu();
    }

    private async Task CloseMenu()
    {
        _ = MainContentGrid.FadeTo(1, AnimationDuration);
        _ = MainContentGrid.ScaleTo(1, AnimationDuration);
        await MainContentGrid.TranslateTo(0, 0, AnimationDuration, Easing.CubicIn);
    }
}