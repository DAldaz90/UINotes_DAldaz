using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UINotes_DAldaz
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UI_NotesCalc : ContentPage
    {
        public UI_NotesCalc()
        {
            InitializeComponent();
            user.Text = "Usuario conectado: " + luser;
        }

        private void B_info_Clicked(object sender, EventArgs e)
        {
            // Campos Primera Nota

            double t_val = Convert.ToDouble(t_tracing_note.Text);
            double e_val = Convert.ToDouble(t_eva_note.Text);

            // Control si es mayor 10

            if (t_val > 10)

            {
                DisplayAlert("Error de Usuario !!", "La nota de seguimiento no debe ser mayor a 10", "Cerrar");
            }

            if (e_val > 10)

            {
                DisplayAlert("Error de Usuario !!", "La nota del examen no debe ser mayor a 10", "Cerrar");
            }

            if (t_val <= 10 && e_val <= 10)

            {
                double resultado = (t_val * 0.3) + (e_val * 0.2);
                t_first_grade.Text = resultado.ToString();
            }            

        }

        private void B_info2_Clicked(object sender, EventArgs e)
        {

            // Campos Segunda Nota

            double t_val2 = Convert.ToDouble(t_tracing_note2.Text);
            double e_val2 = Convert.ToDouble(t_eva_note2.Text);

            // Control si es mayor 10 

            if (t_val2 > 10)

            {
                DisplayAlert("Error de Usuario !!", "La nota de seguimiento no debe ser mayor a 10", "Cerrar");
            }
            if (e_val2 > 10)

            {
                DisplayAlert("Error de Usuario !!", "La nota del examen no debe ser mayor a 10", "Cerrar");
            }

            if (t_val2 <= 10 && e_val2 <= 10)

            {
                double resultado = (t_val2 * 0.3) + (e_val2 * 0.2);
                t_grade2.Text = resultado.ToString();
            }            

        }

        private void B_verify_Clicked(object sender, EventArgs e)
        {
            double t_val = Convert.ToDouble(t_tracing_note.Text);
            double e_val = Convert.ToDouble(t_eva_note.Text);
            double t_val2 = Convert.ToDouble(t_tracing_note2.Text);
            double e_val2 = Convert.ToDouble(t_eva_note2.Text);

            double val1 = Convert.ToDouble(t_first_grade.Text);
            double val2 = Convert.ToDouble(t_grade2.Text);

            if (val1 == 0)

            {
                DisplayAlert("Error de Usuario !!", "Primero debe calcular la nota del 1er parcial", "Cerrar");
            }
            if (val2 == 0)

            {
                DisplayAlert("Error de Usuario !!", "Debe calcular la nota del 2do parcial", "Cerrar");
            }

            double result = ((t_val * 0.3) + (e_val * 0.2)) + ((t_val2 * 0.3) + (e_val2 * 0.2));

            if (result < 5 && val1 > 0 && val2 > 0)

            {
                DisplayAlert("De mal en Peor !!", "\nEstudiante Reprobado" + " " + result, "Cerrar");
            }

            if (result > 5 && result < 7 && val1 > 0 && val2 > 0)

            {
                DisplayAlert("Vamos mal !!", "\nEstudiante Complementario" + " " + result, "Cerrar");
            }

            if (result > 7 && result < 10 && val1 > 0 && val2 > 0)

            {
                DisplayAlert("Muy bien !!", "\nEstudiante Aprobado" + " " + result, "Cerrar");
            }
        }
    }
}
