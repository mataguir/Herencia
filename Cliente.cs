using System;
using System.Collections;

namespace EJ_Herencia
{
    public class Cliente : Persona {
        string Domicilio {get;}
        public ArrayList listaClientes = new ArrayList();
        public Cliente (String dom, String nom, string ap, string correo) : base (nom, ap, correo){
            this.Domicilio = dom;
        }
        public void AgregarCliente (Cliente cliente) {
            listaClientes.Add(cliente);
        }
    }
}