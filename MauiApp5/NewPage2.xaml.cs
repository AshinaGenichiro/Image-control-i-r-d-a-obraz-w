namespace MauiApp5;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
	{
		InitializeComponent();
		string[] links = new string[] {
            "https://cdn.gracza.pl/i/h/22/509882179.jpg",
            "https://cdn.gracza.pl/galeria/gry13/grupy/1193641562.jpg",
            "https://www.purepc.pl/image/news/2026/02/28_resident_evil_requiem_rozbija_bank_na_steamie_nowy_horror_jest_niekwestionowanym_hitem_i_najpopularniejsza_gra_w_serii_0_b.jpg",
            "https://gaming-cdn.com/images/products/18371/orig/resident-evil-remake-trilogy-trilogy-pc-game-steam-us-ca-cover.jpg?v=1747751322",
            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcThEx00gvaNYBnTkdp6poYK5aCf0IQt_lsiPQ&s"
        };
		for (int i = 0; i < links.Length; i++)
		{
			var image = new Image { Source = links[i],Aspect = Aspect.AspectFill, HeightRequest=200};
		}
	}
   
}