using System;

namespace GerenciadorTarefas.Models;

public class Tarefa
{
    public int Id { get; set; }
    public string Descricao { get; set; }

    public bool Concluida { get; set; }

    public Tarefa(string descricao)
    {
        Descricao = descricao;
        Concluida = false;
    }
    public Tarefa(string descricao, bool concluida)
    {
        Descricao = descricao;
        Concluida = concluida;
    }

    public static Tarefa CriarTarefa(string descricao, bool concluida = false)
    {
        return new Tarefa(descricao, concluida);
    }

    public void AlternarStatus()
    {
        Concluida = !Concluida;
    }

}
