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
            Boolean[] arrayBooleanos = new Boolean[longitudArray];

            for (int i = 0; i < longitudArray; i++)
            {
                Console.Write("Longitud de la contraseña {0}: ", i+1);
                int longitudContrasenya = Convert.ToInt32(Console.ReadLine());

                arrayContrasenyas[i] = new Pasword(longitudContrasenya);
                Console.WriteLine(arrayContrasenyas[i].Contrasenya) ;

                arrayBooleanos[i] = arrayContrasenyas[i].esFuerte();
                Console.WriteLine("Contraseña {0} : {1}", i + 1, arrayBooleanos[i]);
            }

            Console.ReadLine();
        }
    }
}
