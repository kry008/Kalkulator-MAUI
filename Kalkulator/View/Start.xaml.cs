namespace Kalkulator.View;

public partial class Start : ContentPage
{
	public Start()
	{
		InitializeComponent();
        Device.StartTimer(TimeSpan.FromSeconds(5), () =>
        {
            Navigation.PushAsync(new Interfejs());
            return false;
        });
    }
}