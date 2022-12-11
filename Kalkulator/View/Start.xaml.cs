namespace Kalkulator.View;

public partial class Start : ContentPage
{
	public Start()
	{
		InitializeComponent();
        //after 5s go to interfejs.xaml
        Device.StartTimer(TimeSpan.FromSeconds(5), () =>
        {
            Navigation.PushAsync(new Interfejs());
            return false;
        });
    }
}