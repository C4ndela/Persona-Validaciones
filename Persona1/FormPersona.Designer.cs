namespace Entidades
{
    partial class FormPersona
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
            this.components = new System.ComponentModel.Container();
            this.btn_edad = new System.Windows.Forms.Button();
            this.btn_Persona = new System.Windows.Forms.Button();
            this.txt_fechaNac = new System.Windows.Forms.TextBox();
            this.txt_Dni = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Edad = new System.Windows.Forms.Label();
            this.Edad = new System.Windows.Forms.Label();
            this.fechaNac = new System.Windows.Forms.Label();
            this.DNI = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.ErrorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDNI = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorfechaNac = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDNI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorfechaNac)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_edad
            // 
            this.btn_edad.Location = new System.Drawing.Point(383, 132);
            this.btn_edad.Name = "btn_edad";
            this.btn_edad.Size = new System.Drawing.Size(93, 30);
            this.btn_edad.TabIndex = 19;
            this.btn_edad.Text = "Edad";
            this.btn_edad.UseVisualStyleBackColor = true;
            this.btn_edad.Click += new System.EventHandler(this.btn_edad_Click);
            // 
            // btn_Persona
            // 
            this.btn_Persona.Location = new System.Drawing.Point(417, 65);
            this.btn_Persona.Name = "btn_Persona";
            this.btn_Persona.Size = new System.Drawing.Size(93, 30);
            this.btn_Persona.TabIndex = 18;
            this.btn_Persona.Text = "Cargar";
            this.btn_Persona.UseVisualStyleBackColor = true;
            this.btn_Persona.Click += new System.EventHandler(this.btn_Persona_Click);
            // 
            // txt_fechaNac
            // 
            this.txt_fechaNac.Location = new System.Drawing.Point(155, 138);
            this.txt_fechaNac.Name = "txt_fechaNac";
            this.txt_fechaNac.Size = new System.Drawing.Size(213, 20);
            this.txt_fechaNac.TabIndex = 17;
            this.txt_fechaNac.TextChanged += new System.EventHandler(this.txt_fechaNac_TextChanged);
            this.txt_fechaNac.VisibleChanged += new System.EventHandler(this.txt_fechaNac_VisibleChanged);
            this.txt_fechaNac.Validating += new System.ComponentModel.CancelEventHandler(this.txt_fechaNac_Validating);
            // 
            // txt_Dni
            // 
            this.txt_Dni.Location = new System.Drawing.Point(155, 89);
            this.txt_Dni.Name = "txt_Dni";
            this.txt_Dni.Size = new System.Drawing.Size(213, 20);
            this.txt_Dni.TabIndex = 16;
            this.txt_Dni.TextChanged += new System.EventHandler(this.txt_Dni_TextChanged);
            this.txt_Dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Dni_KeyPress);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(155, 52);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(213, 20);
            this.txt_Nombre.TabIndex = 15;
            this.txt_Nombre.TextChanged += new System.EventHandler(this.txt_Nombre_TextChanged);
            this.txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_KeyPress);
            // 
            // lbl_Edad
            // 
            this.lbl_Edad.AutoSize = true;
            this.lbl_Edad.Location = new System.Drawing.Point(239, 194);
            this.lbl_Edad.Name = "lbl_Edad";
            this.lbl_Edad.Size = new System.Drawing.Size(48, 13);
            this.lbl_Edad.TabIndex = 14;
            this.lbl_Edad.Text = "lbl_Edad";
            // 
            // Edad
            // 
            this.Edad.AutoSize = true;
            this.Edad.Location = new System.Drawing.Point(118, 194);
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(38, 13);
            this.Edad.TabIndex = 13;
            this.Edad.Text = "Edad: ";
            // 
            // fechaNac
            // 
            this.fechaNac.AutoSize = true;
            this.fechaNac.Location = new System.Drawing.Point(35, 141);
            this.fechaNac.Name = "fechaNac";
            this.fechaNac.Size = new System.Drawing.Size(114, 13);
            this.fechaNac.TabIndex = 12;
            this.fechaNac.Text = "Fecha de Nacimiento: ";
            // 
            // DNI
            // 
            this.DNI.AutoSize = true;
            this.DNI.Location = new System.Drawing.Point(76, 91);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(41, 13);
            this.DNI.TabIndex = 11;
            this.DNI.Text = "D.N.I : ";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(60, 52);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(50, 13);
            this.Nombre.TabIndex = 10;
            this.Nombre.Text = "Nombre: ";
            // 
            // ErrorNombre
            // 
            this.ErrorNombre.ContainerControl = this;
            // 
            // errorDNI
            // 
            this.errorDNI.ContainerControl = this;
            // 
            // errorfechaNac
            // 
            this.errorfechaNac.ContainerControl = this;
            // 
            // FormPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_edad);
            this.Controls.Add(this.btn_Persona);
            this.Controls.Add(this.txt_fechaNac);
            this.Controls.Add(this.txt_Dni);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lbl_Edad);
            this.Controls.Add(this.Edad);
            this.Controls.Add(this.fechaNac);
            this.Controls.Add(this.DNI);
            this.Controls.Add(this.Nombre);
            this.Name = "FormPersona";
            this.Text = "FormPersona";
            this.Load += new System.EventHandler(this.FormPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDNI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorfechaNac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_edad;
        private System.Windows.Forms.Button btn_Persona;
        private System.Windows.Forms.TextBox txt_fechaNac;
        private System.Windows.Forms.TextBox txt_Dni;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_Edad;
        private System.Windows.Forms.Label Edad;
        private System.Windows.Forms.Label fechaNac;
        private System.Windows.Forms.Label DNI;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.ErrorProvider ErrorNombre;
        private System.Windows.Forms.ErrorProvider errorDNI;
        private System.Windows.Forms.ErrorProvider errorfechaNac;
    }
}