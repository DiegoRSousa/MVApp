using MVApp.Model;
using MVApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MVApp.View
{
    public partial class LivrosView : ContentPage
    {
        public LivrosView()
        {
            InitializeComponent();
            this.BindingContext = new LivrosViewModel();
            this.Lista.ItemTapped += async (sender, e) =>
            {
                var livro = e.Item as Livro;
                await App.Current.MainPage.Navigation.PushAsync(new AutorView(livro.Autor));
            };
        }
    }
}
