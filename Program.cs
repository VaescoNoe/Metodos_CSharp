
using System;

class Program
{
    static void Main(string[] args)
    {
        metodoUno();
        Console.WriteLine(metodoCuatro($"Mensaje: {Console.ReadLine()}"));

        metodoCinco(dato: "Dato", dato0: 0, dato1: 1);
        metodoCinco(dato0: 9, dato1: 8, dato: "Data");
        metodoCinco(dato1: 500, dato: "Datos", dato0: 200);

        Console.ReadLine();
    }

    static void metodoUno()
    {
        Console.WriteLine("Hola Mundo");
        metodoDos(1, 3);
    }

    static void metodoDos(int a, int b)
    {
        Console.WriteLine(a + b);
        Console.WriteLine(metodoTres(a, b));
        Console.WriteLine(metodoTres(a, b, 5));
    }

    //static int metodoTres(int a, int b)
    //{
    //    return a-b;
    //}

    static int metodoTres(int a, int b, int optionalint = 10)
    {
        return a + b + optionalint;
    }

    static string metodoCuatro(string msg) => msg;

    static void metodoCinco(string dato, int dato0, int dato1)  {

        Console.WriteLine("{0}", dato);
        Console.WriteLine("{0}", dato0);
        Console.WriteLine("{0}", dato1);
    }

   


}

