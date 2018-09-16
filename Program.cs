using System;
using System.Collections;

namespace EJ_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado mateo = new Empleado (3966756, 31, "Mateo", "Aguirre", "mateinsis@gmail.com");
            Cliente mat = new Cliente ("Somme 1608", "Mateo", "Aguirre", "mateinsis@gmail.com");
            CD XandY = new CD ("X&Y", "Pop", 2008, "Coldplay");
            mat.AgregarCliente(mat);
            mateo.AgregarEmpleado(mateo);
            XandY.AgregarCD(XandY);
            MailSender ms = new MailSender ("mateinsis@gmail.com", "mateinsis@gmail.com");
            ECliente e1 = new ECliente ("Feliz Cumpleaños!", "mateinsis@gmail.com", "mateinsis@gmail.com", "Te deseamos un muy feliz cumple!");
            ms.EnviarMail (e1.Remitente,"Mateo Aguirre" , e1.Destinatario, e1.Asunto, e1.Contenido);
            ECliente e2 = new ECliente ("Promo", "mateinsis@gmail.com", "mateinsis@gmail.com", "Se ha ganado un viaje gratis!");
            ms.EnviarMail (e2.Remitente,"Mateo Aguirre" , e2.Destinatario, e2.Asunto, e2.Contenido);
        }
    }
}
