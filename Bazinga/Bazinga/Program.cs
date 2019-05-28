using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazinga
{
    class Program
    {
        static void Main()
        {
            int x = Convert.ToInt32(Console.ReadLine()); //Recebe o número de vezes que irá repetir o jogo
            string[] resultados = new string[x]; //Array para guardar os resultados do jogo
            for (int i = 0; i < x; i++) //repete o jogo x número de vezes
            {
                string input = Console.ReadLine(); //Recebe o input do usuario
                string[] escolhas = input.Split(' '); //Divide o input do usuario em duas variaveis
                resultados[i] = CheckWinner(CheckIndex(escolhas[0]), CheckIndex(escolhas[1])); //Salva o resultado da partida em uma array
            }
            foreach (string result in resultados) //Escreve todos os resultados na tela
            {
                Console.WriteLine(result);
            }
            Console.ReadKey(); //Impede que o programa feche automaticamente
        }
        /* 
         * As opções receberam uma ordem de acordo que afetam uma a outra: 
         * 
         *    (0)        (1)       (2)        (3)        (4)      |   (0)
         *  tesoura --> papel --> pedra --> lagarto --> spock --> | tesoura
         *  
         * considerando que a numeração comece do zero a partir da opção escolhida nesta mesma ordem
         * a relação de vitória e derrota sempre será a mesma, ou seja, se considerarmos que o primeiro
         * jogador, jogar TESOURA (0) ,ele sempre perderá para PEDRA (2) e SPOCK (4), e sempre ganhará para
         * PAPEL (1) e LAGARTO (3), além de empatar com (0), e a relação numérica nunca muda, portanto ao mudar
         * o valor da escolha para zero e mudar os valores da ordem de acordo, é possivel obter o vencedor ao
         * checar se o número escolhido pelo segundo jogador é igual a algum desses valores.
         *
         *  
        */
        static string CheckWinner(int Sheldon, int Raj) 
        {
            if (Sheldon == 5 || Raj == 5) //Caso o valor seja inválido
            {
                return "Invalido";
            }
            else
            {
                int[] valores = new int[5] { 0, 1, 2, 3, 4 }; //Cria uma array que guarda os valores da ordem
                for (int i = 0; i < 5; i++) //Faz um loop para atualizar os valores de acordo com o novo valor da ordem que recebe 0
                {
                    valores[i] -= Sheldon; //Diminui o valor da escolha do Sheldon para a posição da Ordem
                    if (valores[i] < 0)  //Atribui 5 ao valor caso ele seja negativo para garantir que a posição da ordem está correta
                    {
                        valores[i] += 5;
                    }
                }
                if (valores[Raj] == 1 || valores[Raj] == 3) //Checa se a escolha de Raj vale '1' ou '3' que representa uma vitória de Sheldon
                {
                    return "Bazinga!";
                }
                else if (valores[Raj] == 2 || valores[Raj] == 4) //Checa se a escolha de Raj vale '2' ou '4' que representa derrota de Sheldon
                {
                    return "Raj trapaceou!";
                }
                else if (valores[Raj] == 0) //Checa se a escolha de Raj vale '0' que representa um empate entre os dois
                {
                    return "De novo!";
                }
                else //caso em que ocorra algum erro
                {
                    return "Ocorreu um erro";
                }
            }
        }
        static int CheckIndex(string x) //Checa a palavra recebida para retornar um dos números
        {
            string escolha = x.ToLower(); //muda a palavra para minúsculo para evitar erros
            switch (escolha)          
            {
                case "tesoura": //tesoura --> 0
                    return 0;


                case "papel":  //papel --> 1
                    return 1;


                case "pedra":  //pedra --> 2
                    return 2;


                case "lagarto": //lagarto --> 3
                    return 3;


                case "spock":  //spock --> 4
                    return 4;

                default:  //qualquer palavra que não seja uma das quatro retorna o valor 5 que representa inválido
                    return 5;
            }
        }
    }
}
