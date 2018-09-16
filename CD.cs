using System;
using System.Collections;

namespace EJ_Herencia
{
    public class CD {
        String Nombre;
        String Genero;
        Int32 Año;
        String Interprete;
        ArrayList listaCanciones = new ArrayList();
        public ArrayList listaCD = new ArrayList();
        public CD (String nom, String gen, Int32 año, String inter){
            Nombre = nom;
            Genero = gen;
            Año = año;
            Interprete = inter;
        }
        public void AgregarCD (CD cd) {
            listaCD.Add(cd);
        }
    }
}