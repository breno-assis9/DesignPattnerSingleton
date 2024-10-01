using GerenciadorConfiguracoes.Models;

namespace GerenciadorConfiguracoes.Services
{
    public class ConfiguracaoSingleton
    {
        private static readonly Lazy<ConfiguracaoSingleton> _instance =
            new(() => new ConfiguracaoSingleton());

        public static ConfiguracaoSingleton Instance => _instance.Value;

        public Configuracao Config { get; private set; }

        private ConfiguracaoSingleton()
        {
            Config = new Configuracao
            {
                DatabaseHost = "localhost",
                DatabaseUser = "root",
                DatabasePassword = "senha123"
            };
        }

        public void AtualizarConfiguracoes(Configuracao novaConfiguracao)
        {
            Config = novaConfiguracao;
        }
    }
}
