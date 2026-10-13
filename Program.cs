using System;
using GerenciadorTarefas.Models;
using GerenciadorTarefas.Services;

// Testando a classe Tarefa diretamente no Program.cs
// Tarefa minhaTarefa = new Tarefa("Estudar C# e POO", true);
// Console.WriteLine($"Tarefa: {minhaTarefa.Descricao}");
// Console.WriteLine($"Está concluída? {minhaTarefa.Concluida}");
// minhaTarefa.AlternarStatus();
// Console.WriteLine($"Após alternar, está concluída? {minhaTarefa.Concluida}");

// Testando a classe GerenciadorService
GerenciadorService gerenciador = new GerenciadorService();

bool continuar = true;
while (continuar)
{
    Console.WriteLine("\n=== Gerenciador de Tarefas ===");
    Console.WriteLine("1. Adicionar tarefa");
    Console.WriteLine("2. Listar tarefas");
    Console.WriteLine("3. Sair");

    Console.Write("Escolha uma opção: ");
    string opcao = Console.ReadLine();

    if(opcao == "")
    {
        Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
        Console.WriteLine("\n===================================================");
        continue;
    }
    else if(opcao == "1")
    {
        Console.Write("Digite o nome da tarefa: ");
        string descricao = Console.ReadLine();
        if(descricao == "")
        {
            Console.WriteLine("Descrição da tarefa não pode ser vazia.");
            Console.WriteLine("\n===================================================");
            continue;
        }

        Tarefa novaTarefa = new Tarefa(descricao);
        gerenciador.AdicionarTarefa(novaTarefa);
    }
    else if(opcao == "2")
    {
        gerenciador.ListarTarefas();
    }
    else if(opcao == "3")
    {
        continuar = false;
        Console.WriteLine("\n============== Finalizando o Menu =================\n");
    }
}