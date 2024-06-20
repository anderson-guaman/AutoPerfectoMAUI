using AutoPerfectoMAUI.Models;
using Pokemones.Services;

namespace AutoPerfectoMAUI
{
    public partial class CatalogoAutos : ContentPage
    {
        int count = 0;

        public CatalogoAutos()
        {
            InitializeComponent();
            CargarAutos();
        }

        public async void CargarAutos()
        {
            AutosServices _api = new AutosServices();
            var list_autos = await _api.GetAutos();
            lstAutos.ItemsSource = list_autos;
        }

        public async void ViewPokemonInfo(object sender, SelectedItemChangedEventArgs e)
        {
            Auto auto = (Auto)e.SelectedItem;
            //string url_pokemon = pokemon.URL;
            await Navigation.PushAsync(new InfoAuto(auto));
        }
    }

}
