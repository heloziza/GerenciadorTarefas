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

    public void AlternarStatus()
    {
        Concluida = !Concluida;
    }

}
