namespace Clima;

public partial class MainPage : ContentPage
{
const string Url="HPPTS://api.hgbrasil.com/eather? woeid=455927&key=3091de3d";
	public MainPage()
	{
		InitializeComponent();
	}
   Respota resposta;
}
void TestarLayout()
{
	results.Temp=23;
}
void PreencherTela()
{
  LabelTemp.Text= resposta.results.Temp. ToString();
  LabelCity.Text= resposta.results.City;
  LabelDescription.Text= resposta.results.Description.ToString();
  LabelRain .Text= resposta.results.Rain;
  LabelSunrise.Text= resposta.results.Sunrise;
  LabelHumidity.Text= resposta.results.Humidity;
   LabelHumidity.Text= resposta.results.Humidity;
}