using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


/* ______________________CONVERSÃO/CASTING_________________*/

//Conversão de Valores - Casting
//Convert. e Parse
//Convert -> metodo primeiro depois o valor que quero converter
int a = Convert.ToInt32("5");

//Parse faz o msm processo -> o valor que eu quero converter e o .Parse depois e NÃO EXISTE METODO PARA STRING
int b = int.Parse("5");

//para converter para string precisa usar apenas o .ToString(); pois é um OBJETO


/* 
Diferença entre Parse e Convert-> tratamento de valores nulos (null)
Convert -> retorna 0, nao da erro
Parse -> retorna um erro,não aceita valores nulos

*/


//Console.WriteLine($"{a},{b}");

// Cast implicito, é um casting que nao é necessario fazer o casting usando Parse ou Convert, geralmente de int para double, int para long, sempre dos menores valores de byte para os maiores valores de byte EX: 8 Bytes -> 16 Bytes mas não o contrário, me retorna um erro.

int c = 5;
double d = c;

//Console.WriteLine(c);

// para converter de maneira mais segura é usando o TryParse no qual é esperado a saida usando os atributos da variável e depois a mensagem de erro ou usar o out tipo (int.bool,et) que vai retornar o valor padão do tipo de dado

/* ______________________CONDICIONAIS_________________*/

//IF E ELSE

/* 

int quantidadeEstoque = 10;
int quantidadeCompra = 10;


if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda Inválida!");
}
else if (quantidadeEstoque >= quantidadeCompra) // if Aninhado => if...else if...else if... ...else
{
    Console.WriteLine("Venda realizada");
}
else
{
    Console.WriteLine("Saldo no estoque insuficiente ");
}
*/

//CASE

/*
Console.WriteLine("Escreva uma letra:");

string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "0":
    case "u":
        Console.WriteLine("Vogal");
        break;
    
    default:
        Console.WriteLine("Não é vogal");
        break;

}

*/


/* ______________________OP. LÓGICOS_________________*/

//OR ||


bool maiorDeIdade = false;
bool autorizacaoDoResponsavel = false;

if(maiorDeIdade || autorizacaoDoResponsavel)
{
    Console.WriteLine("Entrada Liberada");
}
else
{
    Console.WriteLine("Entrada Proibida");
}


//AND &&

bool frequenciaMinima = true;
double mediaNotas = 6.5;

if  (frequenciaMinima && mediaNotas >= 7)
{
    Console.WriteLine("Aprovado!");
}
else
{
    Console.WriteLine("Reprovado!!");
}

//NOT ! -> inverte o booleano e relacionado ao valor não 
//EX. Não choveu, Não esta tarde.

bool choveu = false;
bool estaTarde = true;

if(!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar");
}
else
{
    Console.WriteLine("Irei Dormir");
}  
