using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW3_2021_2c_Clase_1.Logica
{
    public class IMC
    {
        public static double calcularIMC(string peso, string altura, out string detalles)
        {
            if (!double.TryParse(peso, out double doublePeso))
            {
                throw new ArgumentException("El valor ingresado no es un nro entero valido.");
            }

            if (!double.TryParse(altura, out double doubleAltura))
            {
                throw new ArgumentException("El valor ingresado no es un nro entero valido.");
            }

            double resultado = doublePeso / (doubleAltura * doubleAltura);


            if( resultado < 18.50){
                detalles = "Bajo peso - ";
                if(resultado < 16)
                {
                    detalles += "Delgadez severa (<16,00)";
                }
                else if (resultado > 17)
                {
                    detalles += "Delgadez leve (17,00 - 18,49)";
                }
                else
                {
                    detalles += "Delgadez moderada (16,00 - 16,99)";
                }
            }
            else if(resultado >= 18.5 && resultado < 25)
            { 
                detalles = "Normal (18,5 - 24,99)";
            }
            else if (resultado >= 30)
            {
                detalles = "Obesidad - ";
                if (resultado >= 40)
                {
                    detalles += "Obesidad mórbida (>=40,00)";
                }
                else if (resultado > 17)
                {
                    detalles += "Obesidad leve (30,00 - 34,99)";
                }
                else
                {
                    detalles += "Obesidad media (35,00 - 39,99)";
                }
            }
            else
            {
                detalles = "Sobrepeso - Preobesidad (25,00 - 29,99)";
            }

            return resultado;
        }
    }
}
