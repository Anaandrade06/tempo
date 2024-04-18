namespace Clima;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
 results results = new result();
  
  void TestarLayout()
{
	results.temp=23;
}
void preenchertela()
LabelTemp.Text = results.temp.ToString();

}
