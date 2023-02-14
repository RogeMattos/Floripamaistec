using Construtores;

Pessoa pessoa1 = new Pessoa("Guilherme",20);
Console.WriteLine($"O nome da pessoa 1 é: {pessoa1.nome}");

Pessoa pessoa2 = new Pessoa("Fernando",20,1.83f);
Console.WriteLine($"O nome da pessoa 2 é: {pessoa2.nome}, {pessoa2.idade},{pessoa2.altura}");

Pessoa pessoa3 = new Pessoa();
Console.WriteLine($"O nome da pessoa 3 é: {pessoa3.nome}, {pessoa3.idade},{pessoa3.altura}");