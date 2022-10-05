﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppGuiaCursoDS.Models;

namespace AppGuiaCursoDS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VerComponente : ContentPage
    {
        public VerComponente(Componente c)
        {
            InitializeComponent();
            BindingContext = c;
        }
    }
}