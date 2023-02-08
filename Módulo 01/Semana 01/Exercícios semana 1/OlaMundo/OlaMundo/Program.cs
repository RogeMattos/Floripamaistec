// See https://aka.ms/new-console-template for more information
//comentário
Console.WriteLine("olá Mundo");  //saída de dados, impressão em tela

int numeroInteiro = 10; // declaração de varável inteira, recebendo valor 10
long numeroMaior = 1099999L; // Declaração de variável long recebendo 1099999
float numeroQuebrado = 6.8f; // Declaraçãop de varável tipo float
double numeroQuebradoMaior = 101.99999999D; // Declaraçãop de varável tipo double
char letra = 'Z'; //Declaraçãop de varável tipo char (1 caracter)
string texto = "A turma estreito é a melhor."; // Declaraçãop de varável tipo string, recebendo uma frase
bool variavelBooleana = true; //Declaraçãop de varável tipo boolean, recebendo valor verdadeiro
DateTime data = DateTime.Now; //Declaraçãop de varável tipo DateTime (data até segundos), armazenando os segundos atuais
DateTime outraData = new DateTime(2023,01,31); // Instanciando objeto da classe DateTime, passando parâmetros como mês e dia
texto.ToUpper(); // Convertendo o texto para letras maísculas
Console.WriteLine ("Frase com letras maísculas: " + texto.ToUpper());


string nomeCompleto; // Declaração de varável
Console.Write("Digite o seu nome: "); // Instrução ao usuário, impressão em tela
nomeCompleto = Console.ReadLine(); // Aguardando o usuário digitar no terminal
Console.WriteLine("O seu nome é: " + nomeCompleto); // Saída de dados, concatenando texto com valor da variável

