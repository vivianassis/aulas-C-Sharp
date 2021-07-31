using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1 = 10;
            int var2 = 2;
            int var3 = 6;
            {
            Console.WriteLine (var1);
            Console.WriteLine (var2);
            Console.WriteLine (var3);
            Console.WriteLine (var1 > var2);
            Console.WriteLine (var3 == var2);
            var1++;
            Console.WriteLine (var1);
            --var3;
            Console.WriteLine (var3);
            }
        }
    }
}

/*Crie uma aplicação console contemplando três variáveis inteiras, com nomes livres.
Atribua valores iniciais às três.
Imprima o resultado de cada uma delas em linhas distintas.
Imprima o resultado utilizando operadores de comparação, a sua escolha, entre as duas primeiras variáveis.
Imprima o resultado utilizando operadores de igualdade entre as duas últimas variáveis.
Utilize operadores aritméticos distintos com a primeira e a última variáveis e em seguida imprima o novo resultado das duas em linhas distintas.*/


/*Console mostrou as respostas
C:\Users\NOTEBOOK\OneDrive\Área de Trabalho\Conhecimentos e Amostras\C#>dotnet run
10
2
6
True
False
11
5*/