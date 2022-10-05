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
                    Nome ="Linguagem, Trabalho e Tecnologia",
                    AtribuicoesResponsabilidades = "Comunicar-se em língua portuguesa, utilizando o vocabulario técnico da área e " +
                                                    "elaborar resgistros e planilhas de acompanhamento e controle de atividaes",
                    ValoresAtitudes = "Incentivar o diálogo e a interlocução Responsabilizar-se pela produção, utlização e"+
                                      "divulgação de informações. Estimular a produtividade",

                };
              await Navigation.PushAsync(new VerComponente(c));  
            }

            }catch(Exception ex)
            {
                await DisplaAlert("Ops!", ex.Message, "OK");
        }



        private async void Button_Clicked1(object sender, EventArgs e)
        {
            try 
            {
                var c = new Componente
                {
                    Nome ="Programação e algoritimo",
                    AtribuicoesResponsabilidades = "Comunicar-se em língua portuguesa, utilizando o vocabulario técnico da área e " +
                                                    "elaborar resgistros e planilhas de acompanhamento e controle de atividaes",
                    ValoresAtitudes = "Incentivar o diálogo e a interlocução Responsabilizar-se pela produção, utlização e"+
                                      "divulgação de informações. Estimular a produtividade",

                };
              await Navigation.PushAsync(new VerComponente(c));  
            }

            }catch(Exception ex)
            {
                await DisplaAlert("Ops!", ex.Message, "OK");
           }


        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            try 
            {
                var c = new Componente
                {
                    Nome ="Linguagem, Trabalho e Tecnologia",
                    AtribuicoesResponsabilidades = "Comunicar-se em língua portuguesa, utilizando o vocabulario técnico da área e " +
                                                    "elaborar resgistros e planilhas de acompanhamento e controle de atividaes",
                    ValoresAtitudes = "Incentivar o diálogo e a interlocução Responsabilizar-se pela produção, utlização e"+
                                      "divulgação de informações. Estimular a produtividade",

                };
              await Navigation.PushAsync(new VerComponente(c));  
            }

            }catch(Exception ex)
            {
                await DisplaAlert("Ops!", ex.Message, "OK");
            }

       private async void Button_Clicked_3(object sender, EventArgs e)
        {
            try 
            {
                var c = new Componente
                {
                    Nome ="Linguagem, Trabalho e Tecnologia",
                    AtribuicoesResponsabilidades = "Comunicar-se em língua portuguesa, utilizando o vocabulario técnico da área e " +
                                                    "elaborar resgistros e planilhas de acompanhamento e controle de atividaes",
                    ValoresAtitudes = "Incentivar o diálogo e a interlocução Responsabilizar-se pela produção, utlização e"+
                                      "divulgação de informações. Estimular a produtividade",

                };
              await Navigation.PushAsync(new VerComponente(c));  
            }

            }catch(Exception ex)
            {
                await DisplaAlert("Ops!", ex.Message, "OK");

            }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            try 
            {
                var c = new Componente
                {
                    Nome ="Linguagem, Trabalho e Tecnologia",
                    AtribuicoesResponsabilidades = "Comunicar-se em língua portuguesa, utilizando o vocabulario técnico da área e " +
                                                    "elaborar resgistros e planilhas de acompanhamento e controle de atividaes",
                    ValoresAtitudes = "Incentivar o diálogo e a interlocução Responsabilizar-se pela produção, utlização e"+
                                      "divulgação de informações. Estimular a produtividade",

                };
              await Navigation.PushAsync(new VerComponente(c));  
            }

            }catch(Exception ex)
            {
                await DisplaAlert("Ops!", ex.Message, "OK");
            }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            try 
            {
                var c = new Componente
                {
                    Nome ="Linguagem, Trabalho e Tecnologia",
                    AtribuicoesResponsabilidades = "Comunicar-se em língua portuguesa, utilizando o vocabulario técnico da área e " +
                                                    "elaborar resgistros e planilhas de acompanhamento e controle de atividaes",
                    ValoresAtitudes = "Incentivar o diálogo e a interlocução Responsabilizar-se pela produção, utlização e"+
                                      "divulgação de informações. Estimular a produtividade",

                };
              await Navigation.PushAsync(new VerComponente(c));  
            }

            }catch(Exception ex)
            {
                await DisplaAlert("Ops!", ex.Message, "OK");

            }

        private async void Button_Clicked_6(object sender, EventArgs e)
        {
            try 
            {
                var c = new Componente
                {
                    Nome ="Linguagem, Trabalho e Tecnologia",
                    AtribuicoesResponsabilidades = "Comunicar-se em língua portuguesa, utilizando o vocabulario técnico da área e " +
                                                    "elaborar resgistros e planilhas de acompanhamento e controle de atividaes",
                    ValoresAtitudes = "Incentivar o diálogo e a interlocução Responsabilizar-se pela produção, utlização e"+
                                      "divulgação de informações. Estimular a produtividade",

                };
              await Navigation.PushAsync(new VerComponente(c));  
            }

            }catch(Exception ex)
            {
                await DisplaAlert("Ops!", ex.Message, "OK");
            }

        private async void Button_Clicked_7(object sender, EventArgs e)
        {
            try 
            {
                var c = new Componente
                {
                    Nome ="Linguagem, Trabalho e Tecnologia",
                    AtribuicoesResponsabilidades = "Comunicar-se em língua portuguesa, utilizando o vocabulario técnico da área e " +
                                                    "elaborar resgistros e planilhas de acompanhamento e controle de atividaes",
                    ValoresAtitudes = "Incentivar o diálogo e a interlocução Responsabilizar-se pela produção, utlização e"+
                                      "divulgação de informações. Estimular a produtividade",

                };
              await Navigation.PushAsync(new VerComponente(c));  
            }

            }catch(Exception ex)
            {
                await DisplaAlert("Ops!", ex.Message, "OK");
            }


       }

}