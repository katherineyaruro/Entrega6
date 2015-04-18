using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEmpleados
{
    class Empleado
    {
        //Atributos
        string nombre;
        string apellido;
        string sexo;
        string fechanac;
        string fechaing;
        float salario;

        //constructor vacio
        public void Empleado() 
        {}

        //constructor con parametros
        public Empleado(String nombre, string apellido, string sexo, string fechanaci, string fechaing) 
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.sexo = sexo;
            this.fechanac = fechanac;
            this.fechaing = fechaing;
        }

        //metodos get y set
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Fechanac
        {
            get { return fechanac; }
            set { fechanac = value; }
        }

        public string Fechaing
        {
            get { return fechaing; }
            set { fechaing = value; }
        }

        public float Salario
        {
            get { return salario; }
            set { salario = value; }
        }

    }
}
