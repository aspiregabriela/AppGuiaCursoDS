using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppGuiaCursoDS.Models;

using AppGuiaCursoDS.Views;

namespace AppGuiaCursoDS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComponentePrimeiro : ContentPage
    {
        public ComponentePrimeiro()
        {
            InitializeComponent();

        }

        private async void btn1_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Linguagem, Trabalho e Tecnologia",

                    AtribuicoesResponsabilidades = "Comunicar-se em língua portuguesa,  utilizando o vocabulario técnico da área e " +
                                                    "elaborar resgistros e planilhas de acompanhamento e controle de atividaes",
                    ValoresAtitudes = "Incentivar o diálogo e a interlocução Responsabilizar-se pela produção, utlização e" +
                                      "divulgação de informações. Estimular a produtividade",

                };

                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "ok");

            }
        }

        private async void btn2_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {

                    Nome = "Banco de Dados I",

                    AtribuicoesResponsabilidades = "Modelar Banco de Dados",

                    ValoresAtitudes = "Estimular a organização. Fortalecer a persistencia e o interresse na resolução" +
                                   "de situações-problemas. Promover ações que considerem o respeito ás normas estabelecidas."

                };
            }

            catch (Exception ex)
            {
                await DisplayAlert("OPS!", ex.Message, "OK");
            }

        }

        private async void btn3_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Análise e Projeto de Sistemas",

                    AtribuicoesResponsabilidades = "Elaborar projetos de sistemas de informação. ",

                    ValoresAtitudes = "Estimular a organização.Fortalecer a persistencia e o interresse na resolução" +
                                   "de situações-problemas. Promover ações que considerem o respeito ás normas estabelecidas."
                };

                VerComponente verComponente = new VerComponente(c);
                await Navigation.PopAsync(verComponente);
            }
            catch (Exception ex)
            {
                await DisplayAlert("ops!", ex.Message, "OK");
            }
        }

        private async void btn4_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Design Digital",

                    AtribuicoesResponsabilidades = "Desenvolver elementos gráficos para aplicativos e sites.",

                    ValoresAtitudes = "Incentivar a criatividade. Respeitar as manifestações culturais de outros povos." +
                                    "Incentivar ações que promovam a cooperação."
                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)

            {
                await DisplayAlert("ops!", ex.Message, "OK");
            }

        }

        private async void btn5_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação Web I",

                    AtribuicoesResponsabilidades = "Desenvolveer sites para web",

                    ValoresAtitudes = "Incentivar a criatividade. Estimular a organização. Fortalecer a persistencia" +
                                       "e o interesse na resolução de situações-problemas."
                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("ops!", ex.Message, "OK");

            }


        }

        private async void btn6_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Fundamentos da Infromática",

                    AtribuicoesResponsabilidades = "Operar sistemas computacionais.",

                    ValoresAtitudes = "Desenvolver a criatividade. Incentivar comportamentos éticos. Promover" +
                                       "ações que consideram o respeito ás normas estabelecidas."
                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("ops!", ex.Message, "OK");


            }
            
        }


    }
}