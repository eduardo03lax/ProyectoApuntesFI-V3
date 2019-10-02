namespace PrototipoApuntesFI
{
    partial class FormRegistrarse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbContraseña = new System.Windows.Forms.TextBox();
            this.comboBCarrera = new System.Windows.Forms.ComboBox();
            this.comboBSemestre = new System.Windows.Forms.ComboBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(281, 66);
            this.txtbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(295, 22);
            this.txtbNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Carrera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Semestre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Correo";
            // 
            // txtbCorreo
            // 
            this.txtbCorreo.Location = new System.Drawing.Point(281, 217);
            this.txtbCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtbCorreo.Name = "txtbCorreo";
            this.txtbCorreo.Size = new System.Drawing.Size(295, 22);
            this.txtbCorreo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 273);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Contraseña";
            // 
            // txtbContraseña
            // 
            this.txtbContraseña.Location = new System.Drawing.Point(281, 273);
            this.txtbContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtbContraseña.Name = "txtbContraseña";
            this.txtbContraseña.Size = new System.Drawing.Size(295, 22);
            this.txtbContraseña.TabIndex = 1;
            // 
            // comboBCarrera
            // 
            this.comboBCarrera.FormattingEnabled = true;
            this.comboBCarrera.Items.AddRange(new object[] {
            "Ingeniería Mecatrónica",
            "Ingeniería Mecánica",
            "Ingeniería Industrial",
            "Ingeniería Petrolera",
            "Ingeniería Electrica Electronica",
            "Ingeniería en Computación"});
            this.comboBCarrera.Location = new System.Drawing.Point(281, 112);
            this.comboBCarrera.Margin = new System.Windows.Forms.Padding(4);
            this.comboBCarrera.Name = "comboBCarrera";
            this.comboBCarrera.Size = new System.Drawing.Size(295, 24);
            this.comboBCarrera.TabIndex = 2;
            // 
            // comboBSemestre
            // 
            this.comboBSemestre.FormattingEnabled = true;
            this.comboBSemestre.Items.AddRange(new object[] {
            "1er Semestre",
            "2do Semestre",
            "3er Semestre",
            "4to Semestrre",
            "5to Semestre",
            "6to Semestre",
            "7mo Semestre",
            "8vo Semestre",
            "9no Semestre",
            "10mo Semestre",
            "Egresado"});
            this.comboBSemestre.Location = new System.Drawing.Point(281, 161);
            this.comboBSemestre.Margin = new System.Windows.Forms.Padding(4);
            this.comboBSemestre.Name = "comboBSemestre";
            this.comboBSemestre.Size = new System.Drawing.Size(295, 24);
            this.comboBSemestre.TabIndex = 2;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(281, 342);
            this.BtnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(100, 28);
            this.BtnAceptar.TabIndex = 3;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click_1);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(476, 342);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 28);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FormRegistrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PrototipoApuntesFI.Properties.Resources.backiee_381;
            this.ClientSize = new System.Drawing.Size(724, 554);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.comboBSemestre);
            this.Controls.Add(this.comboBCarrera);
            this.Controls.Add(this.txtbContraseña);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbCorreo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRegistrarse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegistrarse";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRegistrarse_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbContraseña;
        private System.Windows.Forms.ComboBox comboBCarrera;
        private System.Windows.Forms.ComboBox comboBSemestre;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}