using System;

namespace EJ_Herencia
{
    public class ECorporativo : EMail {
        public ECorporativo (String asunto, String rem, String des, String cont) : base (asunto, rem, des, cont){
            cont = "Estimado, "+cont;
        }
    }
}