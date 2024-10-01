using GerenciadorConfiguracoes.Models;
using GerenciadorConfiguracoes.Services;

var configuracaoSingleton = ConfiguracaoSingleton.Instance;

// Exibe as configurações atuais
Console.WriteLine("Configurações Atuais:");
Console.WriteLine($"Host do Banco de Dados: {configuracaoSingleton.Config.DatabaseHost}");
Console.WriteLine($"Usuário do Banco de Dados: {configuracaoSingleton.Config.DatabaseUser}");
Console.WriteLine($"Senha do Banco de Dados: {configuracaoSingleton.Config.DatabasePassword}");

// Atualizando as configurações
var novaConfiguracao = new Configuracao
{
    DatabaseHost = "novo-host",
    DatabaseUser = "novo-usuario",
    DatabasePassword = "nova-senha"
};

configuracaoSingleton.AtualizarConfiguracoes(novaConfiguracao);

// Exibe as novas configurações
Console.WriteLine("\nNovas Configurações:");
Console.WriteLine($"Host do Banco de Dados: {configuracaoSingleton.Config.DatabaseHost}");
Console.WriteLine($"Usuário do Banco de Dados: {configuracaoSingleton.Config.DatabaseUser}");
Console.WriteLine($"Senha do Banco de Dados: {configuracaoSingleton.Config.DatabasePassword}");