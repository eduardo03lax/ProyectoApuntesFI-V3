using System;

namespace Usuarios
{
    public class Usuario
    {
        #region Atributos
        private string nombre;
        private string carrera;
        private string semestre;
        private string correo;
        private string contrasena;
        

        #endregion Atributos
        
        #region Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public string Carrera { get => carrera; set => carrera = value; }
        public string Semestre { get => semestre; set => semestre = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        
        #endregion Propiedades

        #region Metodos

        
        #endregion Metodos
    }
}
