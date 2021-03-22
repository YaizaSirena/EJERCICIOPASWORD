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
        private string Letras = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnÑñOoPpQqRrSsTtUuVvWwXxYyZz0123456789";
        
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
        
        Random r1 = new Random();
        public void generarPasword()
        {
            for (int i = 0; i < Longitud; i++)
            {
                Contraseña += Letras.Substring(r1.Next(0, Letras.Length), 1);
            }
        }

        public bool esFuerte()
        {
            int mayusculas = 0;
            int minusculas = 0;
            int numeros = 0;

            for (int i = 0; i < Contraseña.Length; i++)
            {
                if (char.IsUpper(Contraseña[i])) mayusculas++;
                if (char.IsLower(Contraseña[i])) minusculas++;
                if (char.IsNumber(Contraseña[i])) numeros++;

                if ((mayusculas >= 2) && minusculas >=1 && numeros >=1 ) { return true; }
            }
            return false;
        }
    }
}
