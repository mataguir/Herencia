using System;

namespace EJ_Herencia
{
    public class ECliente : EMail {
        public ECliente (String asunto, String rem, String des, String cont) : base (asunto, rem, des, cont){
            cont = "Estimado cliente, "+cont;
        }
    }
}