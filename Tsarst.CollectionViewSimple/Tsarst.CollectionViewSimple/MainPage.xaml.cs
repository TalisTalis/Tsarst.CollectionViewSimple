using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tsarst.CollectionViewSimple
{
    public partial class MainPage : ContentPage
    {
        public IList<Language> Languages { get; set; } // коллекция в которой хранятся языки программирования
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            Languages = new List<Language>(); // создается экземпляр Листа

            Languages.Add(new Language()
            {

            });

            base.OnAppearing();
        }
    }
}
