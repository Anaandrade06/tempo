namespace Clima;

public partial class MainPage : ContentPage
{
const string Url="HPPTS://api.hgbrasil.com/eather? woeid=455927&key=3091de3d";
	public MainPage()
	{
		InitializeComponent();
	}
   Results results = new Results();

void TestarLayout()
{
	results.Temp=23;
}
void PreencherTela()
{
  LabelTemp.Text= results.Temp. ToString();
  LabelCity.Text= results.City;  
  if ( results.Currently=="dia");
}

}