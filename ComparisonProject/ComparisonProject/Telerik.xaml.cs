using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ComparisonProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Telerik : ContentPage
    {
        public Telerik()
        {
            InitializeComponent();
            calendar.SelectedCellStyle = new CalendarCellStyle
            {
                BackgroundColor = Color.FromHex("#60a8fc"),
                BorderColor = Color.Transparent,
                TextColor = Color.Black
            };
        }
    }
}