using MVApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVApp.ViewModel
{
    public class LivrosViewModel : INotifyPropertyChanged
    {
        public ICommand CarregarCommand { get; set; }
        private ObservableCollection<Livro> livro;
        public ObservableCollection<Livro> Livros {
            get
            {
                return livro;
            }
            set
            {
                livro = value;
                PropertyChanged?.Invoke(this, new  PropertyChangedEventArgs(nameof(Livros))) ;
            }
        }

        public LivrosViewModel()
        {
            CarregarCommand = new Command(async () =>
            {
                var livros = await ApiLivros.Api.GetAsync();
                Livros = new ObservableCollection<Livro>(livros);
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
