using System;

namespace EJ_Herencia
{
    public abstract class EMail {
        public String Asunto {get;}
        public String Remitente {get;}
        public String Destinatario {get;}
        public String Contenido {get;}
        public EMail(String asunto, String rem, String des, String cont) {
            this.Asunto = asunto;
            this.Remitente = rem;
            this.Destinatario = des;
            this.Contenido = cont;
        }
    }
}