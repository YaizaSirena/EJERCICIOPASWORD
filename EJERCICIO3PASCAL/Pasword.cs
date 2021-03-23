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
        public string Contrasenya { get; set; }

        public Pasword()
        {
            Longitud = 8;
            generarPasword();
        }
        
        public Pasword(int LongitudPa)
        {
            Longitud = LongitudPa;
            generarPasword();
        }
        
        public void generarPasword()
        {
            string letras = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnÑñOoPpQqRrSsTtUuVvWwXxYyZz0123456789";
            Random r1 = new Random();
            for (int i = 0; i < Longitud; i++)
            {
                Contrasenya += letras.Substring(r1.Next(0, letras.Length), 1);
            }
        }

        public bool esFuerte()
        {
            int mayusculas = 0;
            int minusculas = 0;
            int numeros = 0;

            for (int i = 0; i < Contrasenya.Length; i++)
            {
                if (char.IsUpper(Contrasenya[i])) mayusculas++;
                if (char.IsLower(Contrasenya[i])) minusculas++;
                if (char.IsNumber(Contrasenya[i])) numeros++;

                if (mayusculas >= 2 && minusculas >=1 && numeros >=1 ) { return true; }
            }
            return false;
        }
    }
}
