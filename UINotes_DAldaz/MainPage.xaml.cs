using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UINotes_DAldaz
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void but_login_Clicked(object sender, EventArgs e)
        {          
        
            string user = "daldaz";
            string password = "N4nd022";

            string T_User = txt_user.Text;
            string T_Pass = txt_pass.Text;

            if (user == T_User & password == T_Pass)
            {
                DisplayAlert("Ingreso Exitoso !", "Datos Válidos !!", "Cerrar");
                Navigation.PushAsync(new UI_NotesCalc());
            }

            else
            {
                DisplayAlert("Error !", "Usuario o Contraseña Incorrecta", "Cerrar");
            }
        }
    }
}
