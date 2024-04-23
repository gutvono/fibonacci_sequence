int restart = 0, numero = 1, ultimo = 1, penultimo = -1, atual = 0;


do
{
    ultimo = 1;
    penultimo = -1;
    atual = 0;

    do
    {
        Console.Clear();

        if (numero <= 0) Console.WriteLine("ERRO: Informe um número maior que 0");

        Console.Write("Informe quantos números da sequência fibonacci você deseja ver:");
        numero = int.Parse(Console.ReadLine());
    } while (numero <= 0);

    for (int i = 0; i < numero; i++)
    {
        atual = ultimo + penultimo;
        Console.Write(atual + "  ");
        penultimo = ultimo;
        ultimo = atual;
    }

    Console.WriteLine("\nDeseja reiniciar o programa?");
    Console.WriteLine("1 - SIM");
    Console.WriteLine("2 - NAO");
    restart = int.Parse(Console.ReadLine());
} while (restart == 1);