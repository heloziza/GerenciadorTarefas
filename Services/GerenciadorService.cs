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
}
