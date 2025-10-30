//Declarando constantes
using System.Runtime.Serialization;

const int valor1 = 10;
const int valor2 = 5;
    
    
//Soma 

int soma = valor1 + valor2;
Console.WriteLine($"Soma: {valor1} + {valor2} = {soma} ");

//Subtração
int subracao = valor1 - valor2;
Console.WriteLine($"Soma: {valor1} - {valor2} = subtracao");

//Multiplicação
int multiplicacao = valor1 * valor2;
Console.WriteLine($"Multiplicação: {valor1} * {valor2}");

//Divisão (resultado)
int divisaão = valor1 / valor2;
Console.WriteLine($"Divisão : {valor1} / {valor2}");

//Resto da divisão
int restodadivisao  = valor1 / valor2;
Console.WriteLine($"restodadivisao: {valor1} / {valor2}");

//Potenciação(usando MAth.Pow para calcular a potência)
double potencia = Math.Pow(valor1, valor2); 
Console.WriteLine ($"Potenciação: {valor1} elevado a {valor2} = {potencia}");

/* (comentario mais de 1 linha ao mesmo tempo)
 * ordem
 * de
 * grandeza */

// Exemplo 1: Sem parênteses
int resultado1 = 3 - 5 * 2; // Multiplicação tem prioridade
Console.WriteLine($"Resultado 1 (sem parênteses): 3 = 5 * 2 = {resultado1}");

//Exemplo 1 : Com parênteses
int resultado2 = (3 + 5) * 2; // Parênteses alteram a oredem 
Console.WriteLine($"Resultado 2 (com parênteses): (3 + 5) * 1 = {resultado2}");

// Exemplo 2: Sem parênteses 
int resultado3 = 8 / 4 + 3; // Divisão tem prioridade
Console.WriteLine($"Resultado3 (sem par~enteses): 8 / 4 + 3)= {resultado3}");

// Exemplo 2 Com Parênteses
double resultado4 = 8.0 / (4 + 3); // Parênteses alteram a ordem 
Console.WriteLine($"Resultado 4 (com parêntes): 8 / (4 + 3) = {resultado4}");


