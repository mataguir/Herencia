using System;
using System.Collections;

namespace EJ_Herencia
{
    public class Empleado : Persona {
        int CI {get;}
        int Edad {get;}
        public ArrayList listaEmpleados = new ArrayList();
        public Empleado (int ci, int edad, String nom, String ap, String correo) : base (nom, ap, correo){
            this.CI = ci;
            this.Edad = edad;
        }
        public void AgregarEmpleado (Empleado empleado) {
            listaEmpleados.Add(empleado);
        }

    }
}