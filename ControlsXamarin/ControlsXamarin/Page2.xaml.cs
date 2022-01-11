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
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();

            List<Alumno> alumnos = new List<Alumno>();

            alumnos.Add(new Alumno { Apellidos="Torrico Márquez", Nombres="Hugo Felipe",Edad=30  });
            alumnos.Add(new Alumno { Apellidos = "García ", Nombres = "Alan", Edad = 30 });
            alumnos.Add(new Alumno { Apellidos = "Fujimori", Nombres = "Albero", Edad = 30 });
            alumnos.Add(new Alumno { Apellidos = "Toledo", Nombres = "Alejandro", Edad = 30 });
            alumnos.Add(new Alumno { Apellidos = "Castillo", Nombres = "Pedro", Edad = 30 });
            alumnos.Add(new Alumno { Apellidos = "PPK", Nombres = "Pablo", Edad = 30 });



            lvAlumnos.ItemsSource = alumnos;

        }
    }
}