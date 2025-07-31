using CrudSimples;
using System;
using System.Collections.Generic;
using System.Linq;

public class Program 
{
    private static List<Tarefa> tarefas = new List<Tarefa>();
    private static int proximoId = 1;

    public static void Main(string[] args)
    {
        while ((true))
        {
            ExibirMenu();
            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    AdicionarTarefa();
                    break;
                case "2":
                    ListarTarefas();
                    break;
                case "3":
                    AtualizarTarefa();
                    break;
                case "4":
                    ExcluirTarefa();
                    break;
                case "5":
                    Console.WriteLine("Saindo do programa...");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    private static void ExibirMenu() 
    {
        Console.WriteLine("--------------------");
        Console.WriteLine(" SISTEMA DE TAFERAS ");
        Console.WriteLine("--------------------");
        Console.WriteLine("1. ADICIONAR TAREFA");
        Console.WriteLine("2. LISTAR TAREFAS");
        Console.WriteLine("3. ATUALIZAR TAREFA");
        Console.WriteLine("4. REMOVER TAREFA");
        Console.WriteLine("5. SAIR");
        Console.WriteLine("\nSelecione uma opção: ");
    }

    private static void AdicionarTarefa() 
    {
        Console.Clear();
        Console.WriteLine("--- Adicionar nova tarefa");
        Console.WriteLine("Digite a tarefa:");
        var titulo = Console.ReadLine();

        Console.WriteLine("Descrição: ");
        var descricao = Console.ReadLine();

        var novaTarefa = new Tarefa(proximoId, titulo, descricao, "Pendente");
        tarefas.Add(novaTarefa);
        proximoId++;

        Console.WriteLine("\nTarefa adicionada com sucesso!");
    }

    private static void ListarTarefas()
    {
        Console.Clear();
        Console.WriteLine("--- LISTA DE TAREFAS ---");
        if (tarefas.Any())
        {
            // Percorre a lista de tarefas e exibe cada uma no console.
            foreach (var tarefa in tarefas)
            {
                Console.WriteLine(tarefa);
            }
        }
        else
        {
            Console.WriteLine("Nenhuma tarefa encontrada.");
        }
    }

    private static void AtualizarTarefa()
    {
        Console.Clear();
        Console.WriteLine("--- Atualizar tarefa ---");
        Console.WriteLine("Digite o ID da tarefa para atualizar: ");

        if (int.TryParse(Console.ReadLine(), out int idParaAtualizar))
        {
            var tarefa = tarefas.FirstOrDefault(t => t.Id == idParaAtualizar);

            if (tarefa != null)
            {
                Console.WriteLine($"\nTarefa encontrada:\n{tarefa}");

                Console.WriteLine("Digite os novos dados: ");

                Console.WriteLine($"Novo titulo ({tarefa.Titulo}): ");
                var novoTitulo = Console.ReadLine();
                if (!string.IsNullOrEmpty(novoTitulo))
                {
                    tarefa.Titulo = novoTitulo;
                }

                Console.WriteLine($"Nova descrição ({tarefa.Descricao}): ");
                var novaDescricao = Console.ReadLine();
                if (!string.IsNullOrEmpty(novaDescricao))
                {
                    tarefa.Descricao = novaDescricao;
                }

                Console.WriteLine($"Novo status ({tarefa.Status}): ");
                var novoStatus = Console.ReadLine();
                if (!string.IsNullOrEmpty(novoStatus) && (novoStatus == "Pendente" || novoStatus == "Concluída"))
                {
                    tarefa.Status = novoStatus;
                }

                Console.WriteLine("\nTarefa atualizada com sucesso!");
            }
            else
            {
                Console.WriteLine("Tarefa com o ID espedificado não encontrado.");
            }
        }
        else 
        {
            Console.WriteLine("ID inválido. Por favor, insira um número.");
        }
    }

    private static void ExcluirTarefa()
    {
        Console.Clear();
        Console.WriteLine("--- Excluir tarefa ---");
        Console.WriteLine("Digite o ID da tarefa para excluir: ");

        if (int.TryParse(Console.ReadLine(), out int idParaExcluir)) 
        {
            var tarefa = tarefas.FirstOrDefault(t => t.Id == idParaExcluir);

            if (tarefa != null)
            {
                tarefas.Remove(tarefa);
                Console.WriteLine("\nTarefa excluída com sucesso!");
            }
            else 
            {
                Console.WriteLine("Tarefa com o ID especificado não encontrado.");
            }
        }
        else
        {
            Console.WriteLine("ID inválido. Por favor, insira um número.");
        }
    }
}



