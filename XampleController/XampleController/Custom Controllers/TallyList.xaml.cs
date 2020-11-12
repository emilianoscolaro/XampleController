using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelliAbb.Xamarin.Controls;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XampleController.Custom_Controllers
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TallyList : ContentView
    {
        public TallyList()
        {
            InitializeComponent();
        }
    }
}