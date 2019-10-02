using System;
using System.Drawing;
using System.Windows.Forms;
using Usuarios;

namespace PrototipoApuntesFI
{
    public partial class FormRegistrarse : Form
    {
        #region Atributos
        private Form FormPadre;
        private Usuario[] usuarios;
        private byte contUs;
        private ErrorProvider errorProvider;


        #endregion Atributos

        #region Propiedades
        public Form FormPadre1 { get => FormPadre; set => FormPadre = value; }

        public byte ContUs
        {
            get => contUs;

            set
            {
                if (value == 3)
                {
                    contUs = 0;
                }
                else
                {
                    contUs = value;
                }
            }
        }

        public Usuario[] Usuarios { get => usuarios; set => usuarios = value; }
        #endregion Propiedades
        public FormRegistrarse(Form FormPadre)
        {
            this.FormPadre1 = FormPadre;
            InitializeComponent();
            Usuarios = new Usuario[3];
            errorProvider = new ErrorProvider();
        }

        private void FormRegistrarse_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormPadre1.Show();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPadre1.Show();


        }        

        private void BtnAceptar_Click_1(object sender, EventArgs e)
        {
            byte indice = 0;   
            try
            {
                Usuario usuario = new Usuario();
                usuario.Nombre = txtbNombre.Text;
                if (usuario.Nombre == "")
                {
                    indice = 1;
                    string error = "No se puede dejar el campo vacío.";
                    throw new ApplicationException(error);
                }
                usuario.Carrera = comboBCarrera.Items[comboBCarrera.SelectedIndex].ToString();               
                usuario.Semestre = comboBSemestre.Items[comboBSemestre.SelectedIndex].ToString();               
                usuario.Correo = txtbCorreo.Text;
                if (usuario.Correo == "")
                {
                    indice = 2;
                    string error = "No se puede dejar el campo vacío.";
                    throw new ApplicationException(error);
                }
                usuario.Contrasena = txtbContraseña.Text;
                if (usuario.Contrasena == "")
                {
                    indice = 3;
                    string error = "No se puede dejar el campo vacío.";
                    throw new ApplicationException(error);
                }                   
                               
                usuarios[ContUs++] = usuario;
                System.Windows.Forms.MessageBox.Show("Su usuario fue registrado con exito, presione el boton Cancelar para regresar al menu principal");                
            }
            catch(ApplicationException error)
            {
                switch (indice)
                {
                    case 1:
                        errorProvider.SetError(txtbNombre, error.Message);
                        break;
                    case 2:
                        errorProvider.SetError(txtbCorreo, error.Message);
                        break;
                    case 3:
                        errorProvider.SetError(txtbContraseña, error.Message);
                        break;
                }
            }
            catch (ArgumentOutOfRangeException )//Arreglar
            {               
                    errorProvider.SetError(comboBCarrera, "Seleccione una carrera.");              
                    errorProvider.SetError(comboBSemestre, "Seleccione una opción.");                
                                                                             
            }           
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
