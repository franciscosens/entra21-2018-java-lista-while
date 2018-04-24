using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploWhile
{
    class Principal
    {
        static void Main(string[] args)
        {
            int numero = 0;
            bool validarNumero = true;
            while(validarNumero == true)
            {
                try
                {
                    Console.Write("Número: ");
                    numero = Convert.ToInt32(Console.ReadLine());
                    if (numero > 0)
                    {
                         validarNumero = false;
                    }
                    else
                    {
                        Console.WriteLine("Número somente > 0");
                    }
                }
                catch (Exception e)
                {
            Console.WriteLine("Número deveria conter somente números");
                }
            }
        }
    }
}
