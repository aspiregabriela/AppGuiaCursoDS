using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGuiaCursoDS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComponentesPrimeiro : ContentPage
    {
        public ComponentesPrimeiro()
        {
            InitializeComponent();
    
        }


        private async void Button_Clicked(object sender, EventArgs e)
        {
            try 
            {
                var c = new Componente
                {

                };

            
            
            
            
            }catch(Exception e)
            {

            }




        }
    }



}