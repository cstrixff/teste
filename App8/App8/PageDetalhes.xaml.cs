using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageDetalhes : ContentPage
    {
        private Jogo jogo;
        public PageDetalhes()
        {
            InitializeComponent();
        }
        public PageDetalhes(Jogo jogo)
        {
            InitializeComponent();
            this.jogo = jogo;
        }
    }
}