using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace PrototipoApuntesFI
{
    public partial class RepositorioUsuarios : Form
    {

        #region Atributos
        private Form formPadre;
        private string nombre;
        private string carrera;
        private string correo;
        private string semestre;
        #endregion Atributos

        #region Parametros
        public Form FormPadre { get => formPadre; set => formPadre = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Carrera { get => carrera; set => carrera = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Semestre { get => semestre; set => semestre = value; }
        #endregion Parametros

        public RepositorioUsuarios(Form FormPadre,string nombre,string carrera,string correo,string semestre)
        {
            this.FormPadre = FormPadre;
            this.Nombre = nombre;
            this.Carrera = carrera;
            this.Correo = correo;
            this.Semestre = semestre;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            if (abrir.ShowDialog() == DialogResult.OK)

            {
                string direccion = abrir.FileName;
                Process proceso = new Process();
                proceso.StartInfo.FileName = direccion;
                proceso.Start();
            }
        }

        //No se cierra del todo el programa
        private void RepositorioUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormPadre.Close();
        }
    }
}
