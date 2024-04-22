namespace Clima;

public partial class MainPage : ContentPage
{
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