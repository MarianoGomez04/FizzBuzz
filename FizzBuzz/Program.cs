//Escribir un programa que muestre en pantalla los números del 1 al 100,
//sustituyendo los múltiplos de 3 por la palabra “fizz”, los múltiplos de 5 por “buzz”
//y los múltiplos de ambos, es decir, los múltiplos de 3 y 5 (o de 15), por la palabra “fizzbuzz”.


//Del 1 al 100



for (int i = 0; i < 100; i++)
{
    //vamos a mostrar los numeros


if (i % 3 == 0 && i % 5 == 0)
{
    //Remplazar i por los numeros
    Console.WriteLine("FizzBuzz");
}

else if (i % 3 == 0)
{
    Console.WriteLine("Fizz");
}

else if (i % 5 == 0)
{
    Console.WriteLine("Buzz");
}

    else
    {
        Console.WriteLine(i);
    }

}


