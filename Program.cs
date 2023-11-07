class Program
{
    static void Main()
    {
        // Serialização da classe
        var pessoa = new Pessoa { Nome = "Maiko", Idade = 31 };
        string jsonPessoa = System.Text.Json.JsonSerializer.Serialize(pessoa);

        // Caminho do arquivo
        string criarArquivoJson = "Pessoas.json";

        // Cria o arquivo JSON
        File.WriteAllText(criarArquivoJson, jsonPessoa);

        Console.WriteLine("Dados da Pessoa serializados em Pessoas.json.");

        // Desserialização do JSON
        if (File.Exists(criarArquivoJson))
        {
            string jsonTexto = File.ReadAllText(criarArquivoJson);
            Pessoa pessoaDesserializada = System.Text.Json.JsonSerializer.Deserialize<Pessoa>(jsonTexto);

            if (pessoaDesserializada != null)
            {
                // Altera os dados
                pessoaDesserializada.Idade = 32;

                // Serializa novamente os dados
                string dadosAtualizados = System.Text.Json.JsonSerializer.Serialize(pessoaDesserializada);

                // Caminho do arquivo JSON atualizado
                string criarArquivoJsonAtualizado = "Pessoas_Dados_Atualizados.json";

                // Cria o novo arquivo JSON atualizado
                File.WriteAllText(criarArquivoJsonAtualizado, dadosAtualizados);
                Console.WriteLine("Os dados de Pessoa.json foram atualizados e estão no arquivo Pessoas_Dados_Atualizados.json.");
            }
            else
            {
                Console.WriteLine("Falha na desserialização. O objeto é nulo.");
            }
        }
        else
        {
            Console.WriteLine($"O arquivo {criarArquivoJson} não existe.");
        }
    }
}
