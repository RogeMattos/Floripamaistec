

List<int> NumPares = new List<int>();
List<int> NumImpares = new List<int>();

for (int i = 0; i < 5; i++)
{
    Console.Write($"Digite o {i + 1}º número: ");
    int numeros = int.Parse(Console.ReadLine());

    // verifica se o número é ímpar ou par
    if (numeros % 2 == 0)
    {
        NumPares.Add(numeros);
    }
    else
    {
        NumImpares.Add(numeros);
    }
}

// coloca os números em ordem crescente
NumImpares.Sort();
NumPares.Sort();

// o método Sum() faz a soma dos números de uma lista
Console.WriteLine($"A lista de números ímpares possui {NumImpares.Count()} números e a soma deles é igual a {NumImpares.Sum()}");
Console.WriteLine($"A lista de números pares possui {NumPares.Count()} números e a soma deles é igual a {NumPares.Sum()}");







