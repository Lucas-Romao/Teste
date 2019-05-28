using System;

namespace Fibonacci_Array
{
    class Program
    {
        static void Main()
        {
            /* Variavel *cenarios>> determina a quantidade de termos a ser calculados e guardados na array
               Variavel i>> utilizada como índice dos for loops utilizados   
               variavel *termo>> guarda o número a ser calculado em cada índice da array
            */
            int i;
            ulong termo, cenarios;
            Console.WriteLine("Escreva a quantidade de termos: "); //Prompt simples para facilitar a visualização
            cenarios = Convert.ToUInt64(Console.ReadLine()); //Leitura do termo
            ulong[] fibonacci = new ulong[cenarios]; //Criação da Array
            Console.WriteLine("Escreva " + cenarios + " termos"); //Mais um prompt para facilitar a visualização
            for(i = 0; i < Convert.ToInt32(cenarios); i++) //Loop que utiliza a variável *cenário para guardar valores em índices diferentes da array
            {
                termo = Convert.ToUInt64(Console.ReadLine()); 
                fibonacci[i] = termo; //Usa a variavel do loop para determinar em qual indice o termo a ser calculado será guardado
            }
            foreach (ulong element in fibonacci) //Repete o calculo para cada elemento existente na array
            {
                Console.WriteLine($"Fib({element}) = {getFibonacci(element)}");
            }
            Console.ReadKey();//Impede que o programa feche antes de mostrar os resultados
        }
        static ulong getFibonacci(ulong x) //Função que identifica o número da sequencia de fibonacci através de um input
        {
            /* Variável num1>> Guarda o valor do primeiro termo da soma da sequencia
             * Variável num2>> Guarda o valor do segundo termo da soma da sequencia
             * Variável Sum>> Guarda o valor da soma dos dois termos da sequencia
             * Variável i>> Index do for loop
            */
            ulong num1 = 0, num2 = 1, sum, i;

            if (x == 0) //Caso em que o valor recebido é 0 e retorna o primeiro termo da série
            {
                return num1; //retorna 0
            }
            else if (x == 1) //Caso em que o valor recebido é 1 e retorna o segundo termo da série
            {
                return num2; //retorna 1
            }
            else if (x > 0 && x <= 60)//Caso em que o valor é calculado através de um loop
            {
                for(i = 1; i < x; i++) //para cada repetição do loop a soma dos dois números é guadada em Sum
                {                           //o primeiro número recebe o valor do segundo número
                    sum = num1 + num2;        //e o segundo número recebe o valor da soma para preparar para a
                    num1 = num2;               //proxima iteração do loop
                    num2 = sum;
                }
                return num2; //Ao fim do loop é retornado o valor do segundo número, que é o valor pedido
            } else
            {
                return 0;
            }
        }
    }
}
