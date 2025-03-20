using System.Windows.Input;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using ProyectoBomba.View;

namespace ProyectoBomba.ViewModel
{
    public class CrearCuentaViewModel
    {
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public ICommand CrearCuentaCommand { get; }

        public CrearCuentaViewModel()
        {
            CrearCuentaCommand = new Command(async () => await CrearCuenta());
        }

        private async Task CrearCuenta()
        {
            // Simulación de creación de cuenta
            await Application.Current.MainPage.DisplayAlert("Éxito", "Cuenta creada correctamente", "OK");

            await Application.Current.MainPage.Navigation.PushAsync(new Login());
        }
    }
}