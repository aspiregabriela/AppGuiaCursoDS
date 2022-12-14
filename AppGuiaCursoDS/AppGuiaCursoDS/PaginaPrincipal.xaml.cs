using AppGuiaCursoDS.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGuiaCursoDS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaPrincipal : MasterDetailPage
    {
        public PaginaPrincipal()
        {
            InitializeComponent();


            
            etec.Source = ImageSource.FromResource("AppGuiaCursoDS.imagens.etec.png");
            
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Inicial)));
            

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Inicial)));
                IsPresented = false;

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(ComponentePrimeiro)));
                IsPresented = false;

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(ComponentesSegundo)));
                IsPresented = false;

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", $"{ex.Message}\n{ex.StackTrace}", "OK");
            }
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(ComponentesTerceiro)));
                IsPresented = false;

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.StackTrace, "OK");
            }
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Vestibulinho)));
                IsPresented = false;

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

    }

}
