//loop for 
using System.Runtime.Serialization;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
//loop de soma
int soma = 0;
for (int i = 1; i <=100; i++)
{

}

Console.WriteLine($"O valor da soma dos numeros de 1 a 100 é: {soma}");

//loop infinito
/*
 * for(; ; )
{
Console.Writeline("Loop infinito");
}
*/

//loop while

int contador =1;
Console.WriteLine(contador);
while (contador <= 5)
{
    contador++;
    Console.WriteLine(contador);

}

// loop do while (faça enquanto)
int novoContador = 2;
do
{

    Console.WriteLine(novoContador);
    novoContador++;
} while (novoContador <= 5);

//loop while
/*
 * while(true)
 * {
       Console.Writeline("esse loop é infinito");

}
*/

//loop foreach
List<string> nomes = new List<string> { "Ana", "Carlos", "João", "Maria" };

//Usando o foreach para percorrer a lista
foreach (string nome in nomes)
{
    Console.WriteLine(nome); //Imprime cada nome na tela
}

// Usando foreach para percorrer  lista de números 
int[] numeros = { 1, 2, 3, 4, 5 };

// Usando o foreach para percorrer o vetor
foreach (int numero in numeros)
{

    Console.WriteLine(numero); // Imprime Cada número exibindo na tela
}










