using System.Diagnostics;
using Microsoft.EntityFrameworkCore.Query.ResultOperators.Internal;
using Xamarin.Forms;

namespace TestEF
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var s = TrackingExpressionNode.SupportedMethods;
            Debug.WriteLine("I'm done. Thank You!");
        }
    }
}
