using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploWhile
{
    class Exemplo04
    {
        public Exemplo04()
        {
            // TODO: corrigir o problema da média

            int soma = 0, maiorNumero = int.MinValue, menorNumero = int.MaxValue;
            Console.WriteLine(maiorNumero);
            string historico = "";

            Console.WriteLine("Digite um número, caso queira sair digite 8001");
            int numero = Convert.ToInt32(Console.ReadLine());
            int quantidade = 0, quantidadePositivo = 0, quantidadeNegativo = 0, quantidadeNeutro = 0;
            while (numero != 8001)
            {
                soma = soma + numero;
                quantidade = quantidade + 1;

                historico = historico + numero + ", ";

                if (numero > maiorNumero)
                {
                    maiorNumero = numero;
                }

                if (numero < menorNumero)
                {
                    menorNumero = numero;
                }

                if (numero > 0)
                {
                    quantidadePositivo = quantidadePositivo + 1;
                }
                else if (numero != 0)
                {
                    quantidadeNegativo = quantidadeNegativo + 1;
                }
                else
                {
                    quantidadeNeutro = quantidadeNeutro + 1;
                }

                Console.WriteLine("Digite um número, para sair digite 8001");
                numero = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();
            double media = soma / quantidade;
            Console.WriteLine("Soma: " + soma);
            Console.WriteLine("Média: " + media);
            Console.WriteLine("Menor número: " + menorNumero);
            Console.WriteLine("Maior número: " + maiorNumero);
            Console.WriteLine("Quantidade Positivos: " + quantidadePositivo);
            Console.WriteLine("Quantidade Negativos: " + quantidadeNegativo);
            Console.WriteLine("Quantidade Neutros: " + quantidadeNeutro);
            Console.WriteLine("Histórico: " + historico);
        }
    }
}
