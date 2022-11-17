using System;

int menu = 1;
double nota;
double mediaAluno;



while (menu != 0)
{
double acumulador = 0;
Console.WriteLine("Digite a quantidade de Notas: ");
int quantidadeNotas = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < quantidadeNotas; i++)
{

    Console.WriteLine("Digite a nota: ");
    nota = Convert.ToDouble(Console.ReadLine());
    acumulador = acumulador + nota;
}

mediaAluno = (acumulador / quantidadeNotas);
    if (mediaAluno > 6)
    {
        Console.WriteLine($"O aluno foi Aprovado com média: {mediaAluno}");
    }else
    {
        Console.WriteLine($"O Aluno foi reprovado com média {mediaAluno}");
    }

Console.WriteLine("Digite 1 para continuar ou 0 para sair....");
menu = Convert.ToInt32(Console.ReadLine());        

}
