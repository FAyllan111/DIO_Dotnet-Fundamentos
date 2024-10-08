
/*
________________________LAÇO FOR______________________________

int numero = 10;



for (int i=0; i <= 10;i++)// declaracao da variavel, condição e interação ++ ou --
{
    Console.WriteLine(numero*i);
}

________________________WHILE___________________________________

int numero = 5;
int contador = 0;


while(contador <=10) // avalia enquanto é verdadeiro e não tem contador inserido
{
    Console.WriteLine(numero * contador); 
    contador ++; // no while se usa ++ depois de se executar a condição depois o incremento
    
    if(contador ==5)// como quebrar o laço antes com uma condição escolhida
    {
    break;
    }   
}

_____________________DO WHILE_________________________________

int soma = 0;
int numero = 0;

/faz tudo que for declarado,depois no final ele verifica se a condição vai ser atendida

do {
    Console.WriteLine("Digite um número: [0]- Para parar");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;

} while (numero!= 0);

Console.WriteLine($"Total da soma dos numeros é :{soma}");
    
*/