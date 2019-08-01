using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace App35.Model
{
    public class Estudiante : INotifyPropertyChanged
    {
        public Estudiante()
        {
            _Nombre = "Samuel";
            _Apellido = "Reyes";
            _CodigoEstudiante = "23829220";
        }
        private string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; CuandoCambie(); }
        }
        private string _Apellido;
        public string Apellido{
            get { return _Apellido; }
            set { _Apellido = value; CuandoCambie(); }
        }
        private string _CodigoEstudiante;

        public event PropertyChangedEventHandler PropertyChanged;

         protected virtual void CuandoCambie([CallerMemberName] string propertyName = null){
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string CodigoEstudiante
        {
            get { return _CodigoEstudiante; }
            set { _CodigoEstudiante = value; CuandoCambie(); }
        }


    }
}
