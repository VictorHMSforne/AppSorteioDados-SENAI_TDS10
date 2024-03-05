using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppSorteioDados
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageDado : ContentPage
    {
        public bool IsPlaying { get;set; }
        public PageDado()
        {
            InitializeComponent();
            //BindingContext = this;
            Random r = new Random();
            int a = r.Next(1, 6);
            if (a == 1)
            {
                FaceDado.Source = "Dado1";
            }
            else if (a == 2)
            {
                FaceDado.Source = "Dado2";
            }
            else if (a == 3)
            {
                FaceDado.Source = "Dado3";
            }
            else if (a == 4)
            {
                FaceDado.Source = "Dado4";
            }
            else if (a == 5)
            {
                FaceDado.Source = "Dado5";
            }
            else if (a == 6)
            {
                FaceDado.Source = "Dado6";
            }

        }

        void btParar_Clicked(object sender, EventArgs e)
        {
            /*IsPlaying = !IsPlaying;
            OnPropertyChanged(nameof(IsPlaying));*/
            
        }

        private async void btVoltar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}