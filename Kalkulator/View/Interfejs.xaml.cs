using static System.Net.Mime.MediaTypeNames;

namespace Kalkulator.View;

public partial class Interfejs : ContentPage
{
    char[] operatory1 = { '+', '-', '*', '/', '%' };
    char[] operatory2 = { '√', '!', '^', ' ', ' ' };

    int zestawOperatorow = 1;
    double wynik;
    string ll1, ll2;
    bool pierwszaLiczba = true;
    bool przecinekPodany = false;
    char znakPodany = ' ';
    string tekst = "";
    public Interfejs()
    {
        InitializeComponent();
    }
    public Interfejs(String text, String wynikZHistorii)
    {
        InitializeComponent();
        poleTekstoweHistoria.Text = text;
        tekst = ll1 = wynikZHistorii;
        poleTekstowe.Text = wynikZHistorii;
        znakPodany = ' ';
        przecinekPodany = false;
        pierwszaLiczba = true;
        ll2 = "";
        wynik = 0.0;
        zestawOperatorow = 1;
    }
    public void znak(char a)
    {
        wyswietl();
        switch (a)
        {
            case '0':
                if (pierwszaLiczba)
                    ll1 = ll1 + "0";
                else
                    ll2 = ll2 + "0";
                break;
            case '1':
                if (pierwszaLiczba)
                    ll1 = ll1 + "1";
                else
                    ll2 = ll2 + "1";
                break;
            case '2':
                if (pierwszaLiczba)
                    ll1 = ll1 + "2";
                else
                    ll2 = ll2 + "2";
                break;
            case '3':
                if (pierwszaLiczba)
                    ll1 = ll1 + "3";
                else
                    ll2 = ll2 + "3";
                break;
            case '4':
                if (pierwszaLiczba)
                    ll1 = ll1 + "4";
                else
                    ll2 = ll2 + "4";
                break;
            case '5':
                if (pierwszaLiczba)
                    ll1 = ll1 + "5";
                else
                    ll2 = ll2 + "5";
                break;
            case '6':
                if (pierwszaLiczba)
                    ll1 = ll1 + "6";
                else
                    ll2 = ll2 + "6";
                break;
            case '7':
                if (pierwszaLiczba)
                    ll1 = ll1 + "7";
                else
                    ll2 = ll2 + "7";
                break;
            case '8':
                if (pierwszaLiczba)
                    ll1 = ll1 + "8";
                else
                    ll2 = ll2 + "8";
                break;
            case '9':
                if (pierwszaLiczba)
                    ll1 = ll1 + "9";
                else
                    ll2 = ll2 + "9";
                break;
            case ',':
                if (przecinekPodany)
                    break;
                if (pierwszaLiczba)
                    ll1 = ll1 + ".";
                else
                    ll2 = ll2 + ".";
                przecinekPodany = true;
                break;
            case '+':
                if (!pierwszaLiczba)
                {
                    DisplayAlert("Błąd", "Operator podany", "OK");
                    return;
                }
                znakPodany = '+';
                pierwszaLiczba = false;
                przecinekPodany = false;
                break;
            case '-':
                if (!pierwszaLiczba)
                {
                    DisplayAlert("Błąd", "Operator podany", "OK");
                    return;
                }
                znakPodany = '-';
                pierwszaLiczba = false;
                przecinekPodany = false;
                break;
            case '*':
                if (!pierwszaLiczba)
                {
                    DisplayAlert("Błąd", "Operator podany", "OK");
                    return;
                }
                znakPodany = '*';
                pierwszaLiczba = false;
                przecinekPodany = false;
                break;
            case '/':
                if (!pierwszaLiczba)
                {
                    DisplayAlert("Błąd", "Operator podany", "OK");
                    return;
                }
                znakPodany = '/';
                pierwszaLiczba = false;
                przecinekPodany = false;
                break;
            case '^':
                if (!pierwszaLiczba)
                {
                    DisplayAlert("Błąd", "Operator podany", "OK");
                    return;
                }
                znakPodany = '^';
                pierwszaLiczba = false;
                przecinekPodany = false;
                break;
            case '%':
                if (!pierwszaLiczba)
                {
                    DisplayAlert("Błąd", "Operator podany", "OK");
                    return;
                }
                znakPodany = '%';
                pierwszaLiczba = false;
                przecinekPodany = false;
                break;
            case '√':
                if (!pierwszaLiczba)
                {
                    DisplayAlert("Błąd", "Operator podany", "OK");
                    return;
                }
                znakPodany = '√';
                pierwszaLiczba = false;
                przecinekPodany = false;
                break;
            case ' ':
                //DisplayAlert("Błąd", "Błędny operator", "OK");
                break;
        }
        wyswietl();
        tekst = tekst + a;
        poleTekstoweHistoria.Text = tekst;
    }

    private void przyciskKalkulator_More(object sender, EventArgs e)
    {
        if (zestawOperatorow == 2)
            zestawOperatorow = 1;
        else
            zestawOperatorow++;
        if (zestawOperatorow == 1)
        {
            btn1.Text = String.Format(operatory1[0] + "");
            btn2.Text = String.Format(operatory1[1] + "");
            btn3.Text = String.Format(operatory1[2] + "");
            btn4.Text = String.Format(operatory1[3] + "");
            btn5.Text = String.Format(operatory1[4] + "");
        }
        else if (zestawOperatorow == 2)
        {
            btn1.Text = String.Format(operatory2[0] + "");
            btn2.Text = String.Format(operatory2[1] + "");
            btn3.Text = String.Format(operatory2[2] + "");
            btn4.Text = String.Format(operatory2[3] + "");
            btn5.Text = String.Format(operatory2[4] + "");
        }
    }

    private void przyciskKalkulator_C(object sender, EventArgs e)
    {
        ll1 = "";
        ll2 = "";
        pierwszaLiczba = true;
        przecinekPodany = false;
        znakPodany = ' ';
        tekst = "";
        poleTekstowe.Text = "0";
        poleTekstoweHistoria.Text = "";
    }

    private void przyciskKalkulator_Moduo(object sender, EventArgs e)
    {
        if (zestawOperatorow == 1)
            znak('%');
        else if (zestawOperatorow == 2)
            znak(' ');
    }

    private void przyciskKalkulator_Dzielenie(object sender, EventArgs e)
    {
        if (zestawOperatorow == 1)
            znak('/');
        else if (zestawOperatorow == 2)
            znak(' ');
    }

    private void przyciskKalkulator_7(object sender, EventArgs e)
    {
        znak('7');
    }

    private void przyciskKalkulator_8(object sender, EventArgs e)
    {
        znak('8');
    }

    private void przyciskKalkulator_9(object sender, EventArgs e)
    {
        znak('9');
    }

    private void przyciskKalkulator_Mnozenie(object sender, EventArgs e)
    {
        if (zestawOperatorow == 1)
            znak('*');
        else if (zestawOperatorow == 2)
            znak('^');
    }

    private void przyciskKalkulator_4(object sender, EventArgs e)
    {
        znak('4');
    }

    private void przyciskKalkulator_5(object sender, EventArgs e)
    {
        znak('5');
    }

    private void przyciskKalkulator_6(object sender, EventArgs e)
    {
        znak('6');
    }

    private void przyciskKalkulator_Odejmowanie(object sender, EventArgs e)
    {
        if (zestawOperatorow == 1)
            znak('-');
        else if (zestawOperatorow == 2)
            znak('!');
    }

    private void przyciskKalkulator_1(object sender, EventArgs e)
    {
        znak('1');
    }

    private void przyciskKalkulator_2(object sender, EventArgs e)
    {
        znak('2');
    }

    private void przyciskKalkulator_3(object sender, EventArgs e)
    {
        znak('3');
    }

    private void przyciskKalkulator_Plus(object sender, EventArgs e)
    {
        if (zestawOperatorow == 1)
            znak('+');
        else if (zestawOperatorow == 2)
            znak('√');
    }

    private async void przyciskKalkulator_Info(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://github.com/kry008");
    }

    private void przyciskKalkulator_0(object sender, EventArgs e)
    {
        znak('0');
    }
    private void przyciskKalkulator_Przecinek(object sender, EventArgs e)
    {
        if (!przecinekPodany)
        {
            znak(',');
            przecinekPodany = true;
        }
        else
        {
            DisplayAlert("Błąd", "Już przecinek jest", "OK");
        }
    }
    public void zapiszDoPliku(double l1, double l2, char znak, double wynik)
    {
        string path = Path.Combine(FileSystem.AppDataDirectory, "obliczenia");
        using (StreamWriter sw = File.AppendText(path))
        {
            sw.WriteLine(l1 + ";" + l2 + ";" + znak + ";" + wynik);
        }

    }

    private void pokazHistorie(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Historia());
    }

    private void przyciskKalkulator_RownaSie(object sender, EventArgs e)
    {
        bool blad = false;
        if (pierwszaLiczba == false)
        {
            switch (znakPodany)
            {
                case '+':
                    wynik = Convert.ToDouble(ll1) + Convert.ToDouble(ll2);
                    break;
                case '-':
                    wynik = Convert.ToDouble(ll1) - Convert.ToDouble(ll2);
                    break;
                case '*':
                    wynik = Convert.ToDouble(ll1) * Convert.ToDouble(ll2);
                    break;
                case '/':
                    if (ll2 == "0" || ll2 == "0.0")
                    {
                        DisplayAlert("Błąd", "Nie dziel przez 0", "OK");
                        blad = true;
                        czyscEkran();
                        return;
                    }
                    wynik = Convert.ToDouble(ll1) / Convert.ToDouble(ll2);
                    break;
                case '^':

                    wynik = Math.Pow(Convert.ToDouble(ll1), Convert.ToDouble(ll2));
                    break;
                case '%':
                    if (ll2 == "0" || ll2 == "0.0")
                    {
                        DisplayAlert("Błąd", "Nie dziel przez 0", "OK");
                        blad = true;
                        czyscEkran();
                        return;
                    }
                    wynik = Convert.ToDouble(ll1) % Convert.ToDouble(ll2);
                    break;
                case '!':
                    wynik = 1;
                    for (int i = 1; i <= Convert.ToDouble(ll2); i++)
                    {
                        wynik *= i;
                    }
                    break;
                case '√':
                    wynik = Math.Pow(Convert.ToDouble(ll1), 1 / Convert.ToDouble(ll2));
                    break;
                case ' ':
                    wynik = Convert.ToDouble(ll1);
                    break;
            }
            if (!blad)
            {
                poleTekstowe.Text = wynik.ToString();
                zapiszDoPliku(Convert.ToDouble(ll1), Convert.ToDouble(ll2), znakPodany, wynik);
                ll1 = wynik.ToString();
                ll2 = "";
                pierwszaLiczba = true;
                przecinekPodany = false;
                tekst = tekst + "=" + wynik.ToString();
                poleTekstoweHistoria.Text = tekst;
                tekst = wynik.ToString();
            }
            else
            {
                czyscEkran();
                poleTekstowe.Text = "Błąd";
            }

        }
        else
        {
            czyscEkran();
            poleTekstowe.Text = "Błąd";
        }
    }
    private void czyscEkran()
    {
        poleTekstowe.Text = "";
        poleTekstoweHistoria.Text = "";
        ll1 = "";
        ll2 = "";
        pierwszaLiczba = true;
        przecinekPodany = false;

    }
    public void wyswietl()
    {
        poleTekstoweHistoria.Text = tekst;
        if (pierwszaLiczba)
            poleTekstowe.Text = ll1;
        else
            poleTekstowe.Text = ll2;
    }
}
