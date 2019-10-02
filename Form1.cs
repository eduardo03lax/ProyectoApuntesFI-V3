using System;
using System.Windows.Forms;

namespace PrototipoApuntesFI
{
    public partial class Form1 : Form
    {
        #region Atributos
        private FormRegistrarse formRegistrarse;
        private FormInicioSesion formInicioSesion;
        #endregion Atributos

        //Form Padre, la primera ventana que aparecera en la pantalla
        public Form1()
        {
            InitializeComponent();

        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (formRegistrarse != null)
            {
                string nombre = formRegistrarse.Usuarios[0].Nombre;
                string contraseña1 = formRegistrarse.Usuarios[0].Contrasena;
                string carrera = formRegistrarse.Usuarios[0].Carrera;
                string correo = formRegistrarse.Usuarios[0].Correo;
                string semestre = formRegistrarse.Usuarios[0].Semestre;
                formInicioSesion = new FormInicioSesion(this, nombre, contraseña1,carrera, correo, semestre);
                formInicioSesion.Show();
                this.Hide();           
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("No se ha registrado ningun usuario");
            }
        }

        private void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            if (formRegistrarse == null)
            {
                formRegistrarse = new FormRegistrarse(this);
                formRegistrarse.Show();
                this.Hide();

            }
        }
    }
}
