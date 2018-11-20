using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
