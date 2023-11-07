class Program
{
    static void Main()
    {

//serializacao da classe
var pessoa = new Pessoa { Nome = "Maiko", Idade = 31};
string jsonPessoa = System.Text.Json.JsonSerializer.Serialize(pessoa);


//caminho do arquivo
string criarArquivoJson = "Pessoas.json";

//cria o arquivo json
File.WriteAllText(criarArquivoJson, jsonPessoa);

// //desserializacao do json
// Pessoa pessoaDesserializada = System.Text.Json.JsonSerializer.Deserialize<Pessoa>(criarArquivoJson);

// // altera os dados
// pessoaDesserializada.Idade = 31;

// // Serializa novamente os dados
// string dadosAtualizados = System.Text.Json.JsonSerializer.Serialize(pessoaDesserializada);

// //Caminho do arquivo json atualizado
// string criarArquivoJsonAtualizado = "Pessoas_Dados_Atualizados.json";

// //cria o novo arquivo json
// File.WriteAllText(criarArquivoJsonAtualizado, dadosAtualizados);
// Console.WriteLine("Os dados de Pessoa.json foram atualizados e estão no arquivo Pessoas_Dados_Atualizados.json");


    }
}




