﻿namespace GestorTareas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxRegister = new System.Windows.Forms.GroupBox();
            this.textoiniciasesion = new System.Windows.Forms.Label();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.labelRegistro = new System.Windows.Forms.Label();
            this.textContraseñaNueva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCorreoNuevo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUsuarioNuevo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonRegistro = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ListaTareas = new System.Windows.Forms.CheckedListBox();
            this.labelAgregaTarea = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDescrip = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.PickerFecha = new System.Windows.Forms.DateTimePicker();
            this.labelPrioridad = new System.Windows.Forms.Label();
            this.comboBoxPrioridad = new System.Windows.Forms.ComboBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxUsuarioLogged = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCorreoLogged = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxRegister.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRegister
            // 
            this.groupBoxRegister.Controls.Add(this.buttonRegistro);
            this.groupBoxRegister.Controls.Add(this.buttonLogin);
            this.groupBoxRegister.Controls.Add(this.textBoxUsuarioNuevo);
            this.groupBoxRegister.Controls.Add(this.label3);
            this.groupBoxRegister.Controls.Add(this.textContraseñaNueva);
            this.groupBoxRegister.Controls.Add(this.label1);
            this.groupBoxRegister.Controls.Add(this.textBoxCorreoNuevo);
            this.groupBoxRegister.Controls.Add(this.label2);
            this.groupBoxRegister.Controls.Add(this.labelRegistro);
            this.groupBoxRegister.Controls.Add(this.textBoxContraseña);
            this.groupBoxRegister.Controls.Add(this.labelContraseña);
            this.groupBoxRegister.Controls.Add(this.textBoxCorreo);
            this.groupBoxRegister.Controls.Add(this.labelCorreo);
            this.groupBoxRegister.Controls.Add(this.textoiniciasesion);
            this.groupBoxRegister.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRegister.Location = new System.Drawing.Point(12, 12);
            this.groupBoxRegister.Name = "groupBoxRegister";
            this.groupBoxRegister.Size = new System.Drawing.Size(330, 478);
            this.groupBoxRegister.TabIndex = 0;
            this.groupBoxRegister.TabStop = false;
            this.groupBoxRegister.Text = "Inicia sesión o registrate";
            this.groupBoxRegister.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textoiniciasesion
            // 
            this.textoiniciasesion.AutoSize = true;
            this.textoiniciasesion.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoiniciasesion.Location = new System.Drawing.Point(6, 39);
            this.textoiniciasesion.Name = "textoiniciasesion";
            this.textoiniciasesion.Size = new System.Drawing.Size(119, 21);
            this.textoiniciasesion.TabIndex = 0;
            this.textoiniciasesion.Text = "Inicia sesión";
            this.textoiniciasesion.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Location = new System.Drawing.Point(6, 78);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(65, 21);
            this.labelCorreo.TabIndex = 1;
            this.labelCorreo.Text = "Correo";
            this.labelCorreo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(78, 78);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(233, 28);
            this.textBoxCorreo.TabIndex = 2;
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(115, 125);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(196, 28);
            this.textBoxContraseña.TabIndex = 4;
            this.textBoxContraseña.UseSystemPasswordChar = true;
            this.textBoxContraseña.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Location = new System.Drawing.Point(6, 125);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(103, 21);
            this.labelContraseña.TabIndex = 3;
            this.labelContraseña.Text = "Contraseña";
            this.labelContraseña.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelRegistro
            // 
            this.labelRegistro.AutoSize = true;
            this.labelRegistro.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistro.Location = new System.Drawing.Point(6, 239);
            this.labelRegistro.Name = "labelRegistro";
            this.labelRegistro.Size = new System.Drawing.Size(100, 21);
            this.labelRegistro.TabIndex = 5;
            this.labelRegistro.Text = "Regístrate";
            this.labelRegistro.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // textContraseñaNueva
            // 
            this.textContraseñaNueva.Location = new System.Drawing.Point(122, 374);
            this.textContraseñaNueva.Name = "textContraseñaNueva";
            this.textContraseñaNueva.Size = new System.Drawing.Size(196, 28);
            this.textContraseñaNueva.TabIndex = 9;
            this.textContraseñaNueva.UseSystemPasswordChar = true;
            this.textContraseñaNueva.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Contraseña";
            this.label1.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // textBoxCorreoNuevo
            // 
            this.textBoxCorreoNuevo.Location = new System.Drawing.Point(85, 327);
            this.textBoxCorreoNuevo.Name = "textBoxCorreoNuevo";
            this.textBoxCorreoNuevo.Size = new System.Drawing.Size(233, 28);
            this.textBoxCorreoNuevo.TabIndex = 7;
            this.textBoxCorreoNuevo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Correo";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // textBoxUsuarioNuevo
            // 
            this.textBoxUsuarioNuevo.Location = new System.Drawing.Point(91, 279);
            this.textBoxUsuarioNuevo.Name = "textBoxUsuarioNuevo";
            this.textBoxUsuarioNuevo.Size = new System.Drawing.Size(227, 28);
            this.textBoxUsuarioNuevo.TabIndex = 11;
            this.textBoxUsuarioNuevo.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Usuario";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(91, 177);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(144, 33);
            this.buttonLogin.TabIndex = 12;
            this.buttonLogin.Text = "Iniciar sesión";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // buttonRegistro
            // 
            this.buttonRegistro.Location = new System.Drawing.Point(91, 423);
            this.buttonRegistro.Name = "buttonRegistro";
            this.buttonRegistro.Size = new System.Drawing.Size(144, 33);
            this.buttonRegistro.TabIndex = 13;
            this.buttonRegistro.Text = "Registrarse";
            this.buttonRegistro.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonAceptar);
            this.groupBox1.Controls.Add(this.comboBoxEstado);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxPrioridad);
            this.groupBox1.Controls.Add(this.labelPrioridad);
            this.groupBox1.Controls.Add(this.PickerFecha);
            this.groupBox1.Controls.Add(this.labelFecha);
            this.groupBox1.Controls.Add(this.textBoxDescrip);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxTitulo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelAgregaTarea);
            this.groupBox1.Controls.Add(this.ListaTareas);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(364, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 641);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tareas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // ListaTareas
            // 
            this.ListaTareas.FormattingEnabled = true;
            this.ListaTareas.Location = new System.Drawing.Point(418, 27);
            this.ListaTareas.Name = "ListaTareas";
            this.ListaTareas.Size = new System.Drawing.Size(281, 533);
            this.ListaTareas.TabIndex = 0;
            // 
            // labelAgregaTarea
            // 
            this.labelAgregaTarea.AutoSize = true;
            this.labelAgregaTarea.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgregaTarea.Location = new System.Drawing.Point(6, 39);
            this.labelAgregaTarea.Name = "labelAgregaTarea";
            this.labelAgregaTarea.Size = new System.Drawing.Size(159, 21);
            this.labelAgregaTarea.TabIndex = 14;
            this.labelAgregaTarea.Text = "Agrega una tarea";
            this.labelAgregaTarea.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(68, 75);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(329, 28);
            this.textBoxTitulo.TabIndex = 15;
            this.textBoxTitulo.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Título";
            // 
            // textBoxDescrip
            // 
            this.textBoxDescrip.Location = new System.Drawing.Point(116, 125);
            this.textBoxDescrip.Multiline = true;
            this.textBoxDescrip.Name = "textBoxDescrip";
            this.textBoxDescrip.Size = new System.Drawing.Size(281, 182);
            this.textBoxDescrip.TabIndex = 17;
            this.textBoxDescrip.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Descripción";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(6, 327);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(60, 21);
            this.labelFecha.TabIndex = 18;
            this.labelFecha.Text = "Fecha";
            // 
            // PickerFecha
            // 
            this.PickerFecha.Location = new System.Drawing.Point(72, 324);
            this.PickerFecha.Name = "PickerFecha";
            this.PickerFecha.Size = new System.Drawing.Size(325, 28);
            this.PickerFecha.TabIndex = 19;
            // 
            // labelPrioridad
            // 
            this.labelPrioridad.AutoSize = true;
            this.labelPrioridad.Location = new System.Drawing.Point(6, 374);
            this.labelPrioridad.Name = "labelPrioridad";
            this.labelPrioridad.Size = new System.Drawing.Size(82, 21);
            this.labelPrioridad.TabIndex = 20;
            this.labelPrioridad.Text = "Prioridad";
            // 
            // comboBoxPrioridad
            // 
            this.comboBoxPrioridad.FormattingEnabled = true;
            this.comboBoxPrioridad.Location = new System.Drawing.Point(94, 371);
            this.comboBoxPrioridad.Name = "comboBoxPrioridad";
            this.comboBoxPrioridad.Size = new System.Drawing.Size(303, 29);
            this.comboBoxPrioridad.TabIndex = 21;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(94, 423);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(303, 29);
            this.comboBoxEstado.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 22;
            this.label6.Text = "Estado";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(153, 480);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(144, 33);
            this.buttonAceptar.TabIndex = 14;
            this.buttonAceptar.Text = "Agregar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 579);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 33);
            this.button1.TabIndex = 24;
            this.button1.Text = "Borrar tarea seleccionada";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxUsuarioLogged);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxCorreoLogged);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 508);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 145);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información de usuario";
            // 
            // textBoxUsuarioLogged
            // 
            this.textBoxUsuarioLogged.Location = new System.Drawing.Point(91, 36);
            this.textBoxUsuarioLogged.Name = "textBoxUsuarioLogged";
            this.textBoxUsuarioLogged.Size = new System.Drawing.Size(227, 28);
            this.textBoxUsuarioLogged.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Usuario";
            // 
            // textBoxCorreoLogged
            // 
            this.textBoxCorreoLogged.Location = new System.Drawing.Point(85, 84);
            this.textBoxCorreoLogged.Name = "textBoxCorreoLogged";
            this.textBoxCorreoLogged.Size = new System.Drawing.Size(233, 28);
            this.textBoxCorreoLogged.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Correo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1090, 676);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxRegister);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxRegister.ResumeLayout(false);
            this.groupBoxRegister.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRegister;
        private System.Windows.Forms.Label textoiniciasesion;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.Label labelRegistro;
        private System.Windows.Forms.TextBox textBoxUsuarioNuevo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textContraseñaNueva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCorreoNuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRegistro;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelAgregaTarea;
        private System.Windows.Forms.CheckedListBox ListaTareas;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDescrip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelPrioridad;
        private System.Windows.Forms.DateTimePicker PickerFecha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxPrioridad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxUsuarioLogged;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCorreoLogged;
    }
}

