using AutoPerfectoMAUI.Models;
using Pokemones.Services;

namespace AutoPerfectoMAUI;

public partial class InfoAuto : ContentPage
{
    public Auto _auto;
	public InfoAuto(Auto auto)
	{
        _auto = auto;
		InitializeComponent();
		BindingContext = auto;
	}

    private async void ComprarAuto(object sender, EventArgs e)
    {
        AutosServices servicios = new AutosServices();
        // Aquí puedes agregar la lógica para comprar el auto
        // Por ejemplo, podrías actualizar el estado del auto en la base de datos
        _auto.Vendido = true;

        // Mostrar una alerta al usuario
        await DisplayAlert("Compra realizada", $"Has comprado el auto {_auto.Marca} {_auto.Modelo}", "OK");

        servicios.ActualizarAuto(_auto);
        // Navegar de regreso a la lista de autos
        await Navigation.PopAsync();
    }

    
}