using dio_dotnet_bootcamp.Models;

Pessoa cliente = new Pessoa();

cliente.Nome = "Jozé";
cliente.Idade = 368;
cliente.Salario = 2965854559.23215151519451;
cliente.Apresentar();

Pessoa pessoaCamelCase = new Pessoa();


DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);