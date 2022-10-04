using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Entidades
{
    public partial class FormPersona : Form
    {
        public FormPersona()
        {
            InitializeComponent();
        }

        Persona UnaPersona;

        private bool ValidarCampos()
        {
           
            if (txt_Nombre.Text == "")
            {
                ErrorNombre.SetError(txt_Nombre, "ingrese su nombre");
                return false; 
            }
            
            if (txt_Dni.Text == "")
            {
                errorDNI.SetError(txt_Nombre, "ingrese su dni");
                return false;
            }

            if (txt_fechaNac.Text == "")
            {
                errorfechaNac.SetError(txt_Nombre, "ingrese su fecha de nacimiento");
                return false;
            }
            else
            {
                DateTime fechaNac_;
                if (!DateTime.TryParse(txt_fechaNac.Text, out fechaNac_))
                {
                    errorfechaNac.SetError(txt_fechaNac, "el formato debe ser DD/MM/AAAA");
                    return false; 
                }
            }
            return true;
        }

        private void btn_Persona_Click(object sender, EventArgs e)  //CARGA PERSONA
        {
          
            if (ValidarCampos())
              UnaPersona = new Persona(Convert.ToString(txt_Nombre.Text), Convert.ToInt32(txt_Dni.Text), Convert.ToDateTime(txt_fechaNac.Text));
            
        }
    

        private void btn_edad_Click(object sender, EventArgs e) //BOTON EDAD CON METODO
        {
            lbl_Edad.Text = Convert.ToString(UnaPersona.edadTotal(UnaPersona.fechaN_p));
        }
        private void txt_fechaNac_TextChanged(object sender, EventArgs e)
        {
        }
        private void FormPersona_Load(object sender, EventArgs e)
        {
        }
        private void txt_Dni_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_Nombre_TextChanged(object sender, EventArgs e)
        {
       
        }
        private void txt_Dni_KeyPress(object sender, KeyPressEventArgs e) //SOLO NUMEROS EN DNI
        {
            if (!(char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back)))
            {
                MessageBox.Show("solo se permiten numeros", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e) // SOLO LETRAS EN NOMBRE 
        {
            if (!(char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back)))
            {
                MessageBox.Show("solo se permiten letras", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
         }

        private void txt_fechaNac_Validating(object sender, CancelEventArgs e)
        {
            //DateTime fechaNac_;
            //if (!DateTime.TryParse(txt_fechaNac.Text, out fechaNac_))
            //{
            //    errorfechaNac.SetError(txt_fechaNac, "el formato debe ser DD/MM/AAAA");
            //}
            //else
            //{
            //    errorfechaNac.SetError(txt_fechaNac, "");
            //}
        }

        private void txt_fechaNac_VisibleChanged(object sender, EventArgs e)
        {
        }
    }
}
