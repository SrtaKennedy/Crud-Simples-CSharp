### Gerenciador de Tarefas (Console App)
Este é um projeto simples de Console App em C# que implementa um sistema de gerenciamento de tarefas com operações CRUD (Create, Read, Update, Delete). Os dados são armazenados temporariamente em uma lista na memória, o que significa que eles são perdidos ao encerrar a aplicação.

### 🚀 Funcionalidades
O aplicativo oferece um menu interativo com as seguintes opções:

1. **Adicionar Tarefa**: Cria uma nova tarefa com um ID, título, descrição e status inicial "Pendente".

2. **Listar Tarefas**: Exibe todas as tarefas atualmente armazenadas na lista.

3. **Atualizar Tarefa:** Permite modificar o título, descrição e/ou status de uma tarefa existente, buscando-a pelo seu ID.

4. **Excluir Tarefa**: Exclui uma tarefa da lista, buscando-a pelo seu ID.

5. **Sair**: Encerra a aplicação.

### 📂 Estrutura do Projeto
O projeto é composto por duas partes principais:
- `Tarefa.cs`: Uma classe que define o modelo de dados para uma tarefa. Possui as - 1. propriedades `Id`, `Titulo`, `Descricao` e `Status`.
-  `Program.cs`: Contém a lógica principal da aplicação, incluindo o menu de navegação e a implementação das operações de CRUD. Ele utiliza uma `List<Tarefa>` estática para armazenar os dados.

### 💻 Como Executar
- Para rodar este projeto, você precisará do .NET SDK instalado.

- Salve o código em um arquivo `Program.cs`.

- Abra o terminal na pasta onde o arquivo foi salvo.

- Execute o seguinte comando para compilar e rodar a aplicação:

```CSharp
dotnet run
```

### 💡 Próximos Passos e Possíveis Melhorias
- **Persistência de Dados**: Atualmente, as tarefas são perdidas ao fechar o programa. Uma melhoria seria salvar os dados em um arquivo de texto, JSON, ou até mesmo conectar a um banco de dados, como o SQL Server ou MySQL.

- **Melhora do Modelo**: O status da tarefa poderia ser um enum em vez de uma string para garantir que apenas valores válidos sejam usados (por exemplo, Pendente, EmAndamento, Concluida).

- **Validação de Entrada**: Adicionar validações mais robustas para garantir que as entradas do usuário estejam no formato esperado.

- **Refatoração**: Separar as operações de CRUD em uma classe dedicada (TarefaService, por exemplo) seguindo um padrão mais profissional e modular.
