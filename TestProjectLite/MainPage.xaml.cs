using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonkeyCache.LiteDB;
using Xamarin.Forms;

namespace TestProjectLite
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            var abc = Barrel.Current.Get<string>(key: "TestKey");
            Barrel.Current.EmptyAll();
            var abc1 = Barrel.Current.Get<string>(key: "TestKey");
            InitializeComponent();
        }
    }
}
