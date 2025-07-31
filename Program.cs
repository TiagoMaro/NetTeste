// See https://aka.ms/new-console-template for more information
using System;
using App.Models;

int idPessoa = 1;
while (true)
{
    Console.Clear();
    Console.WriteLine("Deseja cadastrar uma nova pessoa? (s/n)");
    string resposta = Console.ReadLine()?.ToLower() ?? "";


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

        int idade = 0;
        if (!int.TryParse(idadeInput, out idade))
        {
            Console.WriteLine("Idade inválida. Por favor, digite um número inteiro.");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            continue;
        }

        var pessoa = new Pessoa(idPessoa, nome, idade);
        pessoa.Apresentar();
        Console.WriteLine(pessoa.Id);
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
        idPessoa++;
    }
}



