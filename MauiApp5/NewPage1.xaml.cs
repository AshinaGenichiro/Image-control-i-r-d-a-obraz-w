
namespace MauiApp5;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
    }
    Image image = new Image
    {
        Source = new UriImageSource
        {
            Uri = new Uri("https://content-hub.imgix.net/3DCl3TvYPXzbjcbdlqMras/a9fe7b8e89364ab1be02bd28b61683ac/Porsche_Cayenne_Turbo_GT_drives_through_city_streets_in_scene_from_Resident_Evil_Requiem_hero_desktop.jpg?w=2064"),
            CacheValidity = new TimeSpan(7, 0, 0, 0)
        }
    };
    void changeMainImgAspect(object sender, EventArgs e)
    {
        if (mainImage.Aspect == Aspect.AspectFit)
        {
            mainImage.Aspect = Aspect.AspectFill;
        }
        else if (mainImage.Aspect == Aspect.AspectFill)
        {
            mainImage.Aspect = Aspect.Fill;
        }
        else if (mainImage.Aspect == Aspect.Fill)
        {
            mainImage.Aspect = Aspect.AspectFit;
        }
    
    aspectLabel.Text = "Aktualny tryb wyświetlania to " + mainImage.Aspect.ToString();
    }
}
/* nazwa funkcji: changeMainImgAspect
 * opis funkcji: funkcja zmienia wygląd aspectu obrazka mainImage, oraz zmienia test labela.
 * 
 * parametry funkcji:(object sender, EventArgs e) - standardowe parametry dla funkcji obsługującej zdarzenie kliknięcia
 * 
 * zwracany typ brak
 * 
 * 
 * 
 * 
 */