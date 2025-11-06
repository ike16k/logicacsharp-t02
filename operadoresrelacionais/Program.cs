int a = 10;
int b = 5;

//Operadoresrelacioanais
bool maiorque = a > b;
bool menorque = a < b;
bool igual = a ==b;
bool diferetente  = a != b;
bool maiorOuigual = a >= b;
bool menorOuigual = a <= b;

//exibindo resultado dos opreadores relacionais
Console.WriteLine("\nOperadores Relacionais");
Console.WriteLine($"{a} > {b} : {maiorque}");
Console.WriteLine($"{a} < {b} : {menorque}");
Console.WriteLine($"{a} == {b} : {igual}");
Console.WriteLine($"{a} != {b} : {diferetente}");
Console.WriteLine($"{a} >= {b} : {maiorOuigual}");
Console.WriteLine($"{a} <= {b} : {menorOuigual}");

