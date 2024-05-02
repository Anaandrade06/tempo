using System.Text.Json;
namespace Clima;

public partial class MainPage : ContentPage
{
   Resposta resposta;
  const string Url="HPPTS://api.hgbrasil.com/eather? woeid=455927&key=3091de3d";
	public MainPage()
	{
		InitializeComponent();
      AtualizaTempo();
	}
async void AtualizaTempo()
   {
      try 
      {
      
         var httpClient =new HttpClient();
         var response = await httpClient.GetAsync(Url);
         if (response.IsSuccessStatusCode)
         {
            var content = await response.Content.ReadAsStringAsync();
            resposta = JsonSerializer.Deserialize<Resposta>(content);
         }
         PreencherTela();

      }
        catch (Exception e)
      {
          System.Diagnostics.Debug.WriteLine(e);
      }
   }

void PreencherTela()
{
  LabelTemp.Text= resposta.results.Temp. ToString();

  LabelCity.Text= resposta.results.City;

  LabelDescricao.Text= resposta.results.Description.ToString();

  LabelChuva.Text= resposta.results.Rain.ToString();

  LabelaNascerdosol.Text= resposta.results.Sunrise;

  LabelUmidade.Text= resposta.results.Humidity.ToString();


  
   }
  }
