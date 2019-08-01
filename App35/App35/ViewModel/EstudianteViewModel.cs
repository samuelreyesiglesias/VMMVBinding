using System;
using System.Collections.Generic;
using System.Text;
using App35.Model;
using Xamarin.Forms;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace App35.ViewModel
{
    public class EstudianteViewModel: INotifyPropertyChanged
    {
        public Command Comando { get; set; }
        private string _Nombre;
        public string Nombre{ get { return _Nombre; } set { _Nombre = value; DatosModificados(); }  }
        private string _Apellido;
        public string Apellido { get { return _Apellido; } set { _Apellido = value; DatosModificados(); } }

        private string _Codigo;
        public string Codigo { get { return _Codigo; } set { _Codigo = value; DatosModificados(); } }

        private Estudiante _NuevoEstudiante;
        public Estudiante NuevoEstudiante
        {
            get { return _NuevoEstudiante; }
            set { _NuevoEstudiante = value; DatosModificados(); }
        }
        public EstudianteViewModel()
        {
            NuevoEstudiante = new Estudiante();
            _Nombre = NuevoEstudiante.Nombre;
            _Apellido = NuevoEstudiante.Apellido;
            _Codigo = NuevoEstudiante.CodigoEstudiante;
            Comando = new Command(MostrarInformacion);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void DatosModificados([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
        }
        public void MostrarInformacion()
        {
            
            App.Current.MainPage.DisplayAlert(
                "Mensaje","Mensaje:"+Nombre+"\n"+"Apellido:"+Apellido+"\n"
                +"Codigo:"+Codigo,"ok");
                
        }
    }
}
