# Gerenciador de Configurações Console

Este projeto é uma aplicação de console em .NET 8 que demonstra o uso do padrão Singleton para gerenciar configurações globais.

## Estrutura do Projeto

GerenciadorConfiguracoesConsole/ 
- GerenciadorConfiguracoesConsole.csproj # Arquivo do projeto 
- Program.cs # Ponto de entrada da aplicação 
- Models/ # Contém classes de modelo │ 
- Configuracao.cs # Classe que representa as configurações 
- Services/ # Contém classes de serviço 
- ConfiguracaoSingleton.cs # Implementação do padrão Singleton

## Descrição dos Componentes

### 1. Models/Configuracao.cs

Esta classe representa as configurações da aplicação. Contém as seguintes propriedades:

- `DatabaseHost`: O host do banco de dados.
- `DatabaseUser`: O usuário do banco de dados.
- `DatabasePassword`: A senha do banco de dados.

### 2. Services/ConfiguracaoSingleton.cs

Esta classe implementa o padrão Singleton para garantir que exista apenas uma instância de `ConfiguracaoSingleton` na aplicação.

#### Principais Características:

- **Instância Única**: Utiliza `Lazy<T>` para inicializar a instância de forma segura em ambientes multi-threaded.
- **Configuração Inicial**: A configuração inicial é definida no construtor da classe.
- **Atualização de Configurações**: Um método `AtualizarConfiguracoes` permite que as configurações sejam atualizadas.

### 3. Program.cs

Este arquivo é o ponto de entrada da aplicação. Ele utiliza o Singleton para acessar e exibir as configurações.

## Como Executar o Projeto

Siga os passos abaixo para executar a aplicação:

1. **Clone o Repositório** (se aplicável):

   ```bash
   git clone https://seu-repositorio-url
   cd GerenciadorConfiguracoesConsole
    ```
2. **Certifique-se de ter o .NET 8 instalado.** Você pode verificar a versão do .NET instalada com:

```bash
dotnet --version
```
3. **Execute o Projeto:**
  
No terminal, execute o seguinte comando:

```bash
dotnet run
```

4. **Verifique a Saída**:
   
Após a execução, você verá a seguinte saída no console:

```yaml
Configurações Atuais:
Host do Banco de Dados: localhost
Usuário do Banco de Dados: root
Senha do Banco de Dados: senha123

Novas Configurações:
Host do Banco de Dados: novo-host
Usuário do Banco de Dados: novo-usuario
Senha do Banco de Dados: nova-senha
```
5. **Conclusão**
   
Este projeto ilustra como utilizar o padrão Singleton em uma aplicação de console .NET 8 para gerenciar configurações de forma consistente e centralizada. O padrão garante que as configurações possam ser acessadas e atualizadas em toda a aplicação sem a necessidade de criar múltiplas instâncias.

Você pode expandir este exemplo para incluir funcionalidades adicionais, como a persistência das configurações em um arquivo ou banco de dados.

6. **Contribuições**

Sinta-se à vontade para contribuir com melhorias ou sugestões. Crie uma nova issue ou envie um pull request!

7. **Licença**
Este projeto está licenciado sob a MIT License.
