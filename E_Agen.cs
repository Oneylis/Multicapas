using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class E_Agen
    {
        private String _Nombre;
        private String _Apellido;
        private String _Telefono;
        private String _Genero;
        private String _Estado_Civil;
        private String _Direccion;
        private String _correo;

        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Genero { get => _Genero; set => _Genero = value; }
        public string Estado_Civil { get => _Estado_Civil; set => _Estado_Civil = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Correo { get => _correo; set => _correo = value; }
    }
}
