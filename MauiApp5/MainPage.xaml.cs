using System;

namespace MauiApp5
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
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
    }
}
