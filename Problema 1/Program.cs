// Si enumeramos todos los números naturales a continuación 10 que son múltiplos de 3 o 5, obtenemos 3,5,6 y 9. La suma de estos múltiplos es 23 
// Halla la suma de todos los múltiplos de 3 o 5 abajo 1000

using System.Runtime.CompilerServices;

var list = new List<int>();

for (var i = 0; i < 1000; i++)
{
    if (i % 3 == 0 || i % 5 == 0)
    {
        list.Add(i);
    }
}
Console.WriteLine("La suma de los numeros naturales que son multiplos de 3 y 5 hasta el numero 1000 es: " + list.Sum());

