using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudSimples
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; } // "Pendente", "Concluída"

        public Tarefa(int id, string titulo, string descricao, string status)
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
            Status = status;
        }

        public override string ToString()
        {
            return $"ID: {Id} | Titulo: {Titulo}\nDescrição: {Descricao}\nStatus: {Status}\n---";
        }
    }

}
