namespace Kalkulator.View;

public partial class Start : ContentPage
{

	public Start()
	{
		InitializeComponent();
        Device.StartTimer(TimeSpan.FromSeconds(2), () =>
        {
            Navigation.PushAsync(new Interfejs());
            return false;
        });
    }
    private void przejscie(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Interfejs());
    }
}