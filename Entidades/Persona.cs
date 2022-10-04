using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private int dni;
        private DateTime fechaNac_;

        #region constructor 
        public Persona() { }
        public Persona(string nom, int DNI, DateTime fNac_)
        {
            nombre = nom;
            dni = DNI;
            fechaNac_ = fNac_;
        }
        #endregion

        #region propiedades
        public string nombre_p
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int dni_p
        {
            get { return dni; }
            set { dni = value; }
        }

        public DateTime fechaN_p
        {
            get { return fechaNac_; }
            set { fechaNac_ = value; }
        }


        #endregion

        #region metodo
        //public int edadTotal( DateTime fechaN_p )
        //{
        //    DateTime fechaAcual = DateTime.Today;

        //   int edad = fechaAcual.Year - fechaN_p.Year;
        //    //edad = fechaAcual - fechaNac_;
        //    return edad; 
        //}
        public int edadTotal(DateTime fechaN_p)
        {
            int Edad = DateTime.Today.AddTicks(-fechaN_p.Ticks).Year - 1;
            return Edad;
        }
        #endregion
    }
}
