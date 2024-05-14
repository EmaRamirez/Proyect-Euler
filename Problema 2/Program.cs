// Cada nuevo término de la secuencia de Fibonacci se genera sumando los dos términos anteriores. Al comenzar con 
//  1 y 2 , el primero 10 los terminos seran: 1,2,3,5,8,13,21,34,55,89..
//  Considerando los términos de la sucesión de Fibonacci cuyos valores no excedan los cuatro millones, halla la suma de los términos pares.



var limite = 4000000;
var a = 1;
var b = 2;
var c = 0;
var resultado = 0;
while (b < limite)
{
    c = a + b;
    a = b;
    b = c;
    if (c % 2 == 0)
    {
        resultado += c;
    }
}
Console.WriteLine(resultado);