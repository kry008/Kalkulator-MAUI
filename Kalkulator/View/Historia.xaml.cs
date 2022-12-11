namespace Kalkulator.View;

public partial class Historia : ContentPage
{

    string path = Path.Combine(FileSystem.AppDataDirectory, "obliczenia");
    public Historia()
    {
        InitializeComponent();
        PokazHistorie();
    }
    protected override void OnAppearing()
    {
        PokazHistorie();
    }
    private void PokazHistorie()
    {
        Layout.Children.Clear();
        if (path.Length == 0 || !File.Exists(path))
        {
            if (!File.Exists(path))
            {
                Czysc.IsVisible = false;
                Label label = new Label
                {
                    Text = "Brak historii obliczeñ",
                    FontSize = 20,
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center
                };
                Layout.Children.Add(label);
            }
        }
        else
        {
            Czysc.IsVisible = true;
            string[] lines = File.ReadAllLines(path);
            for (int i = lines.Length - 1; i >= 0; i--)
            {
                string[] parts = lines[i].Split(';');
                Button button = new Button
                {
                    Text = $"{parts[0]} {parts[2]} {parts[1]} = {parts[3]}",
                    Margin = new Thickness(5),
                    FontSize = 20,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.FillAndExpand

                };
                button.Clicked += Button_History;
                Layout.Children.Add(button);
            }
        }
    }
    private void Button_History(object sender, EventArgs e)
    {
        string[] parts = ((Button)sender).Text.Split('=');
        string text = parts[0].Replace(" ", "");
        string wynik = parts[1].Replace(" ", "");
        Interfejs interfejs = new Interfejs(text, wynik);
        Navigation.PushAsync(interfejs);

    }
    private void Button_Clicked_Czysc(object sender, EventArgs e)
    {
        File.Delete(path);
        PokazHistorie();
    }

    private void pokazKalkulator(object sender, EventArgs e)
    {
        Interfejs interfejs = new Interfejs();
        Navigation.PushAsync(interfejs);
    }
}
