using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int[] valores = new int[10]; //Cria uma array para guardar os valores de cada número de 0 a 9
        int t = Convert.ToInt32(Console.ReadLine());//Recebe o número de vezes que o programa será rodado
        string[] resultados = new string[t]; //Cria uma array para receber os resultados de cada teste
        for (int x = 0; x < t; x++) //loop para o número de vezes a ser testado
        {
            string input = Console.ReadLine(); //Recebe os números do usuario
            string[] numeros = input.Split(' '); //Divide o input em uma array
            int num1, num2; //Valores inteiros a serem usados
            bool IsNumeric1 = int.TryParse(numeros[0], out num1); //Tenta converter a string para inteiro
            bool IsNumeric2 = int.TryParse(numeros[1], out num2);
            if (IsNumeric1 && IsNumeric2 && num1 >= 1 && num2 <= 1000000000) //Caso a string possa ser convertida e os números estejam dentro
            {                                                                //de um intervalo aceito executa o código

                for (int z = num1; z <= num2; z++) //Faz um loop que inicia no primeiro número e termina no ultimo da sequencia
                {
                    SetArray(z, valores); //Acrescenta o valor de determinado número para cada iteração do loop
                }
                resultados[x] = ShowArray(valores); //Guarda os valores da array int em uma array de string para serem mostrados na tela de uma vez
                ClearArray(valores); //Limpa os valores da array int para não causar erros na contagem
            }
            else //Caso um dos valores da string não seja númerico ou não esteja dentro dos valores determinado retorna "Entrada invalida" como resultado
            {
                resultados[x] = "Entrada Invalida";
                ClearArray(valores); //Limpa Array por segurança
            }
        }
        foreach (string result in resultados) //Loop para cada resultado
        {
            Console.WriteLine(result);
        }
        Console.ReadKey();//Impede que o programa feche automaticamente
    }
    static void ClearArray(int[] val) //Limpa todos os valores da array
    {
        for (int i = 0; i < 10; i++)
        {
            val[i] = 0; //Atribui 0 ao valor de cada iteração
        }
    }
    static string ShowArray(int[] val) //Retorna uma string com todos os valores da array formatados
    {
        string resultado = $"{val[0]} {val[1]} {val[2]} {val[3]} {val[4]} {val[5]} {val[6]} {val[7]} {val[8]} {val[9]}";
        return resultado;
    }
    static void SetArray(int num, int[] val) //Adiciona um no index de cada número recebido na array
    {
        string number = Convert.ToString(num); //Converte o número para string
        foreach (char j in number)            //e para cada letra nessa string convertida em valor númerico é adicionado 1 a esse index
        {
            int i = (int)Char.GetNumericValue(j); //Converte a letra em número e atribui esse valor ao inteiro i
            val[i]++; //Usa o index do inteiro i para adicionar 1 ao index da array de inteiro
        }
    }
}


