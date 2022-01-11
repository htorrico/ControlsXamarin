using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlsXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            StackLayout stack = new StackLayout();
            Button button = new Button();
            Label label = new Label();

            button.Text = "Hacer click";
            label.Text = "Mi segunda etiqueta";

            stack.Children.Add(button);
            stack.Children.Add(label);


            this.Content = stack;

        }
    }
}