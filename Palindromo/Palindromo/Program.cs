using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Não fui capaz de fazer o programa rodar corretamente

namespace Palindromo
{
    class Program
    {
        static void Main()
        {
            int t = Convert.ToInt32(Console.ReadLine()); //Recebe o numero de vezes a rodar o palindromo
            string[] textos = new string[t]; //Cria uma array para guardar as palavras
            for (int i = 0; i < t; i++)
            {
                textos[i] = Console.ReadLine(); //Guarda as palavras na array
            }
            foreach (string palavra in textos) //Checa a subsequencia de cada palavra na array
            {
                Check(palavra);
            }
            Console.ReadKey(); //Impede que o programa feche rapidamente
        }
        static void Check(string p) //Entra em um loop para remover uma letra da palavra
        {
            p = p.ToLower();
            for (int i = 0; i <= p.Length; i++)
            {
                string x = recursive(p, i); //Loop
                if (x.Length > 1) //Caso a palavra tenha um tamanho maior que 1 é considerada um palindromo
                {
                    Console.WriteLine(x);
                    break;
                }
            }   

        }

        static string recursive(string teste, int i) //Loop para checar se é um palindromo e caso não seja remover uma letra da string
        {
            string localS = teste;
            if (Palindromo(localS)) //Checa se é um palindromo e caso seja verdade retorna a própria palavra
            {
                return localS;
            }
            localS = removeInd(teste, i); //Caso não seja um palindromo remove uma letra de index (i) da palavra
            if (localS.Length > 1 && i > 1) //Checa se o tamanho da palavra é maior que 1
            {
                return recursive(localS, i); //Volta para o loop
            }
            else //Retorna uma palavra de tamanho 1 caso ocorra um erro
            {
                return "x";
            }
        }

        static string removeInd(string original, int index) //remove um index da string
        {
            string retorno = original; //Guarda o valor da string
            int stringsize = retorno.Length; //Guarda o tamanho da string
            if (index == 0) //Caso a letra a ser removida seja a primeira ele retorna uma substring do segundo caractere até o ultimo
            {
                retorno = original.Substring(1, original.Length - 1);
            }
            else if (index == original.Length) //Caso a letra a ser removida seja a ultima ele retorna uma substring do primeiro termo até o penultimo
            {
                retorno = original.Substring(0, original.Length - 1); 
            } else //Caso seja um número entre esses retorna a concatenação de duas substrings uma que começa da primeira letra até a letra a ser removida e outra que começa depois da letra a ser removida até a ultima
            {
                int ind = index + 1;
                int final = stringsize - ind;

                retorno = original.Substring(0,index) + original.Substring(ind, final);
            }
            return retorno; //retorna o resultado
;       }

        static bool Palindromo(string pal) // checa se a string é um palindromo
        {
            string texto = new string(pal.Reverse().ToArray()); //Reverte a string e checa se é igual a string original
            if (texto == pal)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }
    }
}
