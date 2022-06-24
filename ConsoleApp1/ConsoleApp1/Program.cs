using System;
// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hola,mundo!");
Console.WriteLine("La hora es " + DateTime.Now);
Console.WriteLine("Nuevo commit");
Console.WriteLine("Escriba su nombre");
string x=Console.ReadLine();
Console.WriteLine("Su nombre es:");
Console.WriteLine(x);
Console.WriteLine("Este texto solo es visible en main");*/

//Ejercicio 1
Console.WriteLine("Escriba un numero de cifras:");
string n = Console.ReadLine();
Console.WriteLine("Escriba su número de " + n + " cifras:");
string numero = Console.ReadLine();
char[] array = numero.ToCharArray();
char[] arrayinvertido = numero.ToCharArray(); ;
Console.WriteLine("Numero invertido:");

int i = Convert.ToInt32(n) - 1;
foreach (var item in array)
{
    arrayinvertido[i] = item;
    i--;
}
Console.WriteLine(arrayinvertido);