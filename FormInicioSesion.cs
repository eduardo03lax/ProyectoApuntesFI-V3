using System;
using System.Windows.Forms;
using Usuarios;

namespace PrototipoApuntesFI
{
    public partial class FormInicioSesion : Form
    {
        #region Atributos
        private Form FormPadre;
        private RepositorioUsuarios repositorioUsuarios;
        private ErrorProvider ErrorAcceso;
        private FormInicioSesion formInicioSesion;
        private string nombre1;
        private string contraseña1;
        private string carrera;
        private string correo;
        private string semestre;
        private ErrorProvider errorProvider;

        #endregion Atributos

        #region Propiedades
        public Form FormPadre1 { get => FormPadre; set => FormPadre = value; }

        public ErrorProvider ErrorAcceso1 { get => ErrorAcceso; set => ErrorAcceso = value; }
        public RepositorioUsuarios RepositorioUsuarios { get => repositorioUsuarios; set => repositorioUsuarios = value; }
        public string Nombre1 { get => nombre1; set => nombre1 = value; }
        public string Contraseña1 { get => contraseña1; set => contraseña1 = value; }
        public string Carrera { get => carrera; set => carrera = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Semestre { get => semestre; set => semestre = value; }
        #endregion Propiedades
        public FormInicioSesion(Form FormPadre, string nombre1, string contraseña1,string carrera, string correo, string semestre)
        {
            this.Nombre1 = nombre1;
            this.Contraseña1 = contraseña1;
            this.Carrera = carrera;
            this.Correo = correo;
            this.Semestre = semestre;
            this.FormPadre1 = FormPadre;
            InitializeComponent();
            errorProvider = new ErrorProvider();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPadre1.Show();

        }

        private void FormInicioSesion_FormClosing(object sender, FormClosingEventArgs e)
        {

            FormPadre1.Show();
        }

      
        private void BtnIngresar_Click_1(object sender, EventArgs e)
        {
            byte indice = 0;
            try
            {
                string Nombre = txtbNombre.Text;
                if (Nombre == "")
                {
                    indice = 1;
                    string error = "Ingrese nombre de usuario.";
                    throw new ApplicationException(error);
                }
                string Contrasena = txtbContrasena.Text;
                if (Contrasena == "")
                {
                    indice = 2;
                    string error = "Ingrese contraseña.";
                    throw new ApplicationException(error);
                }

                if (Nombre == Nombre1 && Contrasena == Contraseña1)
                {
                    RepositorioUsuarios = new RepositorioUsuarios(this, Nombre, Carrera, Correo, Semestre);
                    RepositorioUsuarios.Show();
                    //Cambie Close por Hide
                    this.Close();
                    FormPadre.Hide();

                }
                /*else
                {


                    //formInicioSesion = new FormInicioSesion(this.FormPadre1, this.Nombre1, this.Contraseña1, this.Carrera, this.Correo, this.Semestre);
                    //formInicioSesion.Show();
                    //FormPadre.Hide();

                }*/
            }
            catch(ApplicationException error)
            {
                switch (indice)
                {
                    case 1:
                        errorProvider.SetError(txtbNombre, error.Message);
                        break;
                    case 2:
                        errorProvider.SetError(txtbContrasena, error.Message);
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Error inesperado.");
            }
        }
    }
}
