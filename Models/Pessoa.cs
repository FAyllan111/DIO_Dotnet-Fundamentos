using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_dotnet_bootcamp.Models
{
    public class Pessoa // nome de classe PascalCase
    {
        //public string Nome { get; set; } 
        public int Idade { get; set; }

        public double Salario { get; set; }

        public DateTime Data { get; set; }
        public void Apresentar()
        
        {
            //Console.WriteLine($"Olá,meu nome é {Nome} e tenho {Idade} anos e recebo R$ {Salario}");
            
        }
    }
}

// nome de classe, propriedade e métodos(variaveis) PascalCase
// nome de variavel camelCase