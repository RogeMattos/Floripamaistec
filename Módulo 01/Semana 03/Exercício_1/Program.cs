using Exercício_1;

Produto produto1 = new Produto("Calculadora", 6.75, 299);

Produto produto2 = new Produto();

Console.WriteLine($"O produto tem nome: {produto1.nome}, valor: {produto1.preco}, quantidade: {produto1.quantidade}");
Console.WriteLine($"O produto tem nome: {produto2.nome}, valor: {produto2.preco}, quantidade: {produto2.quantidade}");
