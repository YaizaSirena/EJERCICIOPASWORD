using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO3PASCAL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce la longitud del array: ");
            int longitudArray = Convert.ToInt32(Console.ReadLine());
            Pasword [] arrayContrasenyas = new Pasword[longitudArray];
            Pasword[] arrayBooleanos = new Pasword[longitudArray];


            for (int i = 0; i < longitudArray; i++)
            {
                Console.Write("Longitud de la contraseña {0}: ", i+1);
                int longitudContrasenya = Convert.ToInt32(Console.ReadLine());

                arrayContrasenyas[i] = new Pasword(longitudContrasenya);
                Console.WriteLine(arrayContrasenyas[i].Contraseña) ;
                arrayBooleanos[i] = new Pasword(longitudContrasenya);
                arrayBooleanos[i].esFuerte();
                Console.WriteLine("contraseña{0},", i+1, arrayBooleanos[i].esFuerte()? "true" : "false");
            }




            Console.ReadLine();
        }
    }
 
    //Crea otro array de booleanos donde se almacene si el password del array de Password es o no fuerte(usa el bucleanterior).
    //Al final, muestra la contraseña y si es o no fuerte(usa el bucle anterior).Usa
    //este simpleformato:
    //contraseña1 valor_booleano1 contraseña2valor_bololeano2
}
