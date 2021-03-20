using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO3PASCAL
{
    class Pasword
    {
        public int Longitud { get; set; } 
        public string Contraseña { get; set; }
        private string LETRAS = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnÑñOoPpQqRrSsTtUuVvWwXxYyZz0123456789";
        public Pasword()
        {
            Longitud = 8;
            Contraseña = ""; //Generar aleatroriamente.
        }
        public Pasword(int LongitudPa)
        {
            Longitud = LongitudPa;
            Contraseña = ""; //aleatoria con Longitud que le pasemos.
        }

        public void asignarContrasenya()
        {
            
            Random r1 = new Random();
            r1.Next(0, Longitud);

            for (int i = 0; i < Longitud; i++)
            {

            }
        }
       

       

    }
//    Haz una clase llamada Password que siga las siguientescondiciones:
//Que tenga los atributos longitud y contraseña.Por defecto, la longitud sera de8.
//Los constructores serán lossiguiente:
//Un constructor pordefecto.
//Un constructor con la longitud que nosotros le pasemos.Generara una contraseña aleatoria con esa longitud.
//Los métodos que implementaserán:
//esFuerte(): devuelve un booleano si es fuerte o no, para que sea fuerte debe tener mas de 2 mayúsculas, mas de 1 minúscula y mas de 5números.
//generarPassword(): genera la contraseña del objeto con la longitudque
//tenga.
//Método get para contraseña ylongitud.
//Método set paralongitud.
}
