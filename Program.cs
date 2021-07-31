using System;
namespace C_
{
    class Program
    {
        static void Main(string[] args)

        {   Console.WriteLine("\r\nOlá, bem vindo! Vamos aprender sobre variáveis, condicionais e repetições.\r\n");
            Console.WriteLine("\r\nAtribuição das variáveis:");
            int var1 = 10;
            int var2 = 2;
            int var3 = 6; 

            {
                Console.WriteLine($"A variável 1 é {var1}.");
                Console.WriteLine($"A variável 2 é {var2}.");
                Console.WriteLine($"A variável 3 é {var3}.\r\n");
                
                Console.WriteLine("Operações:");
                Console.WriteLine($"Dizer que {var1} é maior que {var2} é {var1 > var2}!");
                Console.WriteLine($"Dizer que {var3} é igual a {var2} é {var3 == var2}...");
                var1++;
                Console.WriteLine($"A variável 1 ganhou um e aumentou para {var1}!");
                --var3;
                Console.WriteLine($"A variável 3 perdeu um e diminuiu para {var3}!\r\n");

                Console.WriteLine($"A variável 1 agora é {var1}.");
                Console.WriteLine($"A variável 2 agora é {var2}.");
                Console.WriteLine($"A variável 3 agora é {var3}.\r\n");

                Console.WriteLine("Loop:");
                int cont = 1;
                while (var1 <= 15)
                {
                    Console.WriteLine($"O {var1} é o número {cont} da lista;");
                    var1++;
                    cont++;
                };
            }
            Console.WriteLine($"A variável 1 agora é {var1}, a primeira após cessar o loop.\r\n");

            Console.WriteLine("Somando 10 às novas variáveis:");
            var1 = var1 + 10;
            var2 = var2 + 10;
            var3 = var3 + 10;
            Console.WriteLine($"A variável 1 + 10 é igual a {var1}.");
            Console.WriteLine($"A variável 2 + 10 é igual a {var2}.");
            Console.WriteLine($"A variável 3 + 10 é igual a {var3}.\r\n");

            Console.WriteLine(" Obs.: Para cada variável que atribuirmos lá em cima, todas as operações são realizadas normalmente! \r\n Bom... Isso é tudo pessoal! :D");
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

//=======================================================================

/*Utilizando como base o código-fonte que você construiu na atividade anterior:

1- Adicione uma de repetição que tenha 5 execuções, utilizando a estrutura de controle de sua preferência.
2- Adicione uma nova variável para o controle das repetições.
3- A cada impressão, informe o número da execução em curso.
4- Ao final de cada volta, adicione 10 unidades a cada uma, das três variáveis definidas anteriormente.


Console mostrou:
C:\Users\NOTEBOOK\OneDrive\Área de Trabalho\Conhecimentos e Amostras\C#>dotnet run

Olá, bem vindo! Vamos aprender sobre variáveis, condicionais e repetições.


Atribuição das variáveis:
A variável 1 é 10.
A variável 2 é 2.
A variável 3 é 6.

Operações:
Dizer que 10 é maior que 2 é True!
Dizer que 6 é igual a 2 é False...
A variável 1 ganhou um e aumentou para 11!
A variável 3 perdeu um e diminuiu para 5!

A variável 1 agora é 11.
A variável 2 agora é 2.
A variável 3 agora é 5.

Loop:
O 11 é o número 1 da lista;
O 12 é o número 2 da lista;
O 13 é o número 3 da lista;
O 14 é o número 4 da lista;
O 15 é o número 5 da lista;
A variável 1 agora é 16, a primeira após cessar o loop.

Somando 10 às novas variáveis:
A variável 1 + 10 é igual a 26.
A variável 2 + 10 é igual a 12.
A variável 3 + 10 é igual a 15.

 Obs.: Para cada variável que atribuirmos lá em cima, todas as operações são realizadas normalmente!
 Bom... Isso é tudo pessoal! :D
*/