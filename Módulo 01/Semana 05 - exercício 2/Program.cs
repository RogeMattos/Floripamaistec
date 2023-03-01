//zona segura
FileInfo arquivo = null;
try
{
    Console.Write("Digite o nome do arquivo que voce vai criar: ");
    String nomeArquivo = Console.ReadLine();

    arquivo = new FileInfo(nomeArquivo);

    using (StreamWriter gravadorFluxo = File.AppendText(nomeArquivo))
    {
        gravadorFluxo.WriteLine("Texto de dentro do arquivo");
    }
}

    catch (Exception ex)
{
    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
	
}
finally
{
    Console.WriteLine($"Encerrando o programa...\n");
   // arquivo = null;
    //Console.Clear();
    
}


