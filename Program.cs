// See https://aka.ms/new-console-template for more information
using System;

int idPessoa = 1;
while (true)
{
    Console.Clear();
    Console.WriteLine("Deseja cadastrar uma nova pessoa? (s/n)");
    string resposta = Console.ReadLine()?.ToLower() ?? "n";


    if (resposta == "n")
    {
        Console.WriteLine("Saindo do programa...");
        break;
    }
    else if (resposta != "s")
    {
        Console.WriteLine("Resposta inválida. Por favor, digite 's' para sim ou 'n' para não.");
        continue;
    }
    else
    {
        string nome = String.Empty;
        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine() ?? string.Empty;

        string idadeInput = String.Empty;
        Console.Write("Digite sua idade: ");
        idadeInput = Console.ReadLine() ?? string.Empty;

        var pessoa = new Pessoa(idPessoa, nome, idadeInput != string.Empty ? int.Parse(idadeInput) : 0);
        pessoa.Apresentar();
        Console.WriteLine(pessoa.Id);
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
        idPessoa++;
    }
}



