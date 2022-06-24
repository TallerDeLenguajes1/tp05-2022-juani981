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

//Calculadora V1
Console.WriteLine("Calculadora V1");

bool valido;
var resultado=0; var a = 0;var b = 0;

do
{
    //Console.Clear();
    Console.WriteLine("1.Sumar");
    Console.WriteLine("2.Restar");
    Console.WriteLine("3.Multiplicar");
    Console.WriteLine("4.Dividir");
    Console.Write("Escriba una opcion:");
    int seleccion = Convert.ToInt32(Console.ReadLine());
    switch (seleccion)
    {
        case 1:
            //suma
            Console.WriteLine("Ingrese 2 números a sumar");
            a = Console.Read();
            
            b = Console.Read();
            resultado = a + b;
            valido = true;
            break;
        case 2:
            //resta
            Console.WriteLine("Ingrese 2 números a restar");
            a = Console.Read();
            
            b = Console.Read();
            valido = true;
            resultado = b - a;
            break;
        case 3:
            //multi
            Console.WriteLine("Ingrese 2 números a multiplicar");
            a = Console.Read();
            
            b = Console.Read();
            valido = true;
            resultado=b * a;
            break;
        case 4:
            //div
            Console.WriteLine("Ingrese 2 números a dividir");
            a = Console.Read();
            
            b = Console.Read();
            resultado = a / b;
            valido = true;
            break;
        default:
            Console.WriteLine("Opcion incorrecta, intente nuevamente");
            Console.Clear();
            valido = false;
            break;
    }
    Console.WriteLine("Resultado de la operacion:" + resultado);
    /*Console.Write("Desea realizar otro calculo? 1 para SI");
    //valido = Console.Read();
    if (Console.Read() == 1)
    {
        valido = false;
    }
    else
        valido = true;*/
} while (valido == false);

//Calculadora V2
Console.WriteLine("Calculadora V2");
bool validov2;
do
{
    Console.WriteLine("Ingrese 1 numero");
    var c = Convert.ToDouble(Console.ReadLine());
    
        validov2 = true;

        Console.WriteLine("Valor absoluto de " + c);
        Console.WriteLine(Math.Abs(c));
        Console.WriteLine("Cuadrado de " + c);
        Console.WriteLine(Math.Pow(c, 2));
        Console.WriteLine("Raiz cuadrada de " + c);
        Console.WriteLine(Math.Sqrt(c));
        Console.WriteLine("Seno de " + c);
        Console.WriteLine(Math.Sin(c));
        Console.WriteLine("Coseno de " + c);
        Console.WriteLine(Math.Cos(c));
        Console.WriteLine("Parte entera de " + c);
        Console.WriteLine(Math.Truncate(c));
} while (validov2==false);