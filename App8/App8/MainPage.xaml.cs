using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            colecaoJogos.ItemsSource = Dados.Jogos();
            
        }

        private void colecaoJogos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //PageDetalhes nova = (Jogo)colecaoJogos.SelectedItem)
            Navigation.PushAsync(new PageDetalhes((Jogo)colecaoJogos.SelectedItem));
            
        }
    }
}
