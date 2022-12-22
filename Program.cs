
ushort num = ushort.MaxValue;
ushort temp = checked((ushort)(num + 100));
Console.WriteLine($"Valor: {temp} ");

return;
int numeroSecreto = new Random().Next(0, 100);
ushort intentos = 0;
Console.Clear();
Console.WriteLine($"====================================================================== ");
Console.WriteLine($"Adivine el numero secreto entre 0 y 100.En el menor numero de intentos ");
Console.WriteLine($" Para salir sin adivinar digite 999");
Console.WriteLine($"====================================================================== ");
ushort numero;
Console.Write(" Entre el Numero =>");
do
{
    try
    {
        numero = ushort.Parse(Console.ReadLine());
    }
    catch (FormatException error)
    {
        Console.WriteLine($"====================================================================== ");
        Console.WriteLine($"Debe ingresar numeros.");
        Console.WriteLine($"====================================================================== ");
        // Console.WriteLine($"error:{error}");
        numero = 0;
    }
    catch (Exception err)
    {
        Console.WriteLine($"====================================================================== ");
        Console.WriteLine($"Error de Windows. Consulte con el Admin");
        Console.WriteLine($"====================================================================== ");
        numero = 0;
    }
    finally
    {
        Console.WriteLine($"Paso Por Aqui Siempre ");
    }

    if (numero == 999) break;
    intentos++;
    if (numero < numeroSecreto)
        Console.WriteLine($"Intento :{intentos} => Su numero es menor que el Secreto ");
    if (numero > numeroSecreto)
        Console.WriteLine($"Intento :{intentos} => Su numero es Mayor que el Secreto ");

} while (numero != numeroSecreto);
if (numero == 999)
    Console.WriteLine($"Ummm {intentos} => Veo que no pudo con el reto el numero era {numeroSecreto}");
else
    Console.WriteLine($" Felicitaciones el numero secreto es {numeroSecreto} y lo logro adivinar en {intentos} Intento(s)");

Console.WriteLine($"GAME OVER");