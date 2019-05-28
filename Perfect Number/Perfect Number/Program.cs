using System;

namespace Perfect_Number
{
    class Program
    {
        static void Main()
        {
            int i;
            int T = Convert.ToInt32(Console.ReadLine()); //Pede o número de termos a ser digitado
            int[] numeros = new int[T]; //Cria uma array para guardar todos os números
            for (i = 0; i < T; i++)
            {
                numeros[i]=Convert.ToInt32(Console.ReadLine()); //Armazena o número digitado na array
            }
            foreach (int number in numeros) //Para cada número digitado checa se ele é perfeito
            {
                if (number  >= 1 && number <= 108) //Checa se 1 >= T <= 108
                {
                    if (isPerfect(number)) //Checa se o número é perfeito
                    {
                        Console.WriteLine("Eh perfeito");
                    }
                    else
                    {
                        Console.WriteLine("Nao eh perfeito");
                    }
                }
            }
            Console.ReadKey(); //Impede que o programa feche antes de mostrar os resultados

        }

        static bool isPerfect(int x) //Função que checa se um número é perfeito ou não
        {
            int i, num = 0;
            for (i = 1; i < x; i++) //Para cada número anterior a X começando por 1 faz uma iteração do loop
            {
                if (x % i == 0) //Checa se o número é divisível checando se o resto da divisão por ele é zero
                {
                    num += i; //caso o número seja divisível ele é somado a um contador com o valor inicial de 0
                }
            }
            if (num == x) //checa se o contador é igual ao número inicial e retorna verdadeiro ou falso neste caso
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
