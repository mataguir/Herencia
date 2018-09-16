using System;

namespace EJ_Herencia
{
    public abstract class Persona {
        public string Nombre {get;}
        public string Apellido {get;}
        public string Correo {get;}
        public Persona (string nom, string ap, string correo){
            this.Nombre = nom;
            this.Apellido = ap;
            this.Correo = correo;
        }
    }
}