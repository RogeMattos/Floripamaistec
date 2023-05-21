
/*decimal opcao = 0, num1 = 0,  num2 = 0;

//opcao = int.Parse(Console.ReadLine());

Console.Write("Digite o número 1: ");
num1 = int.Parse(Console.ReadLine());
Console.Write("Digite o número 2: ");
num2 = int.Parse(Console.ReadLine());
Console.WriteLine($" O resultado de {num1} dividido por {num2} é: {num1 / num2}");*/

try
{
    Console.Write("Digite o primeiro número : ");
    decimal num1 = int.Parse(Console.ReadLine());
    Console.Write("Digite o segundo número : ");
    decimal num2 = int.Parse(Console.ReadLine());

    Console.WriteLine($" O resultado de {num1} dividido por {num2} é: {num1 / num2}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Não é possível dividir números por 0; digite outro número diferente de zero!!");
}
catch (FormatException ex)
{
    Console.WriteLine($"Letras não podem ser informadas; digite um número diferente de zero!!");
}
catch (Exception ex)
{
    Console.WriteLine("Ocorreu um erro!!");
}
finally
{
    decimal num1 = 0, num2 = 0;
    Console.WriteLine(num1);
    Console.WriteLine(num2);
}


