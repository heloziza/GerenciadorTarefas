using System;
using GerenciadorTarefas.Models;

namespace GerenciadorTarefas.Services;

public class GerenciadorService
{
    private List<Tarefa> tarefas = new List<Tarefa>();

    public void AdicionarTarefa(Tarefa tarefaNova)
    {
        tarefas.Add(tarefaNova);
    }

    public bool ListaVazia()
    {
        bool vazio = tarefas.Count == 0 ? true : false;
        return vazio;
    }

    public void ListarTarefas()
    {
        if(tarefas.Count == 0)
        {
            Console.WriteLine("Nenhuma tarefa cadastrada.\n");
            return;
        }
        else
        {
            Console.WriteLine("\n================= Lista de Tarefas ================");
            foreach(var task in tarefas)
            {
                Console.WriteLine($"- {task.Descricao} ({(task.Concluida ? "Concluída" : "Pendente")})");
            }
            Console.WriteLine("===================================================");
        }
    }

    public bool VerificarExistenciaTarefa(string descricao)
    {
        return tarefas.Any(t => t.Descricao.Equals(descricao, StringComparison.OrdinalIgnoreCase));
    }

    public void AlternarStatusTarefa(string descricao)
    {
        var tarefa = tarefas.FirstOrDefault(t => t.Descricao.Equals(descricao, StringComparison.OrdinalIgnoreCase));
        if(tarefa != null)
        {
            tarefa.AlternarStatus();
            Console.WriteLine("\n================ Alternando Status ================");    
            Console.WriteLine($"Status da tarefa '{descricao}' alterado para {(tarefa.Concluida ? "Concluída" : "Pendente")}.");
            Console.WriteLine("\n===================================================");
                
        }
        else
        {
            Console.WriteLine($"Tarefa '{descricao}' não encontrada.");
            Console.WriteLine("\n===================================================");
        }
    }

    public void ExcluirTarefa(string descricao)
    {
        var tarefa = tarefas.FirstOrDefault(t => t.Descricao.Equals(descricao, StringComparison.OrdinalIgnoreCase));
        if(tarefa != null)
        {
            tarefas.Remove(tarefa);
            Console.WriteLine("\n================ Excluindo Tarefa ================");    
            Console.WriteLine($"Tarefa '{descricao}' excluída com sucesso.");
            Console.WriteLine("\n===================================================");
        }
        else
        {
            Console.WriteLine($"Tarefa '{descricao}' não encontrada.");
            Console.WriteLine("\n===================================================");
        }
    }
}
