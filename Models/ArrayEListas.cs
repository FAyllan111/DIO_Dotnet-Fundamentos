using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*

_________ARRAY__________

int[] arrayInteiros = new int[3];

arrayInteiros[2] = 58;
arrayInteiros[1] = 57;
arrayInteiros[0] = 5544;

/redimensionando o array podendo aumentar ou diminuir 

Array.Resize(ref arrayInteiros, arrayInteiros.Length+ 3);

arrayInteiros[3] = 454545;

/copiar um array para outro- array de origem, para o array de destino e indica quantos elementos copiar

int[] arrayInteiros2 = new int[6];
Array.Copy(arrayInteiros, arrayInteiros2,arrayInteiros.Length);

/percorrer o array e imprimir ele em tela usa-se os laços de repetição FOR e FOREACH
for (int i = 0; i < arrayInteiros.Length; i++)
{
    Console.WriteLine(arrayInteiros[i]);
}

_____________LISTAS_______________

/diferenças sao as principais diferenças,sempre que possiveis usar listas

List<string> listaString = new List<string>();

listaString.Add("Teste");
listaString.Add("teste2");
listaString.Add("texte");

/percorrer com for e ForEach

for (int i=0; i < listaString.Count;i++)
{
    Console.WriteLine(listaString[i]);
}

/for each -> mais recomendado de se usar para percorrer listas
foreach (string item in listaString)
{
    Console.WriteLine(item);
}
*/