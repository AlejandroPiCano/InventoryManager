using RabbitMQ.Client;

namespace InventoryManager.API.Configurations
{
    public static class HealthCheckHelper
    {
        private readonly static string RabbitMQlocalhostURL = "localhost";
        private readonly static string RabbitMQDockerURL = "rabbitmq";
        public static IConfiguration BuildBasicHealthCheck()
        {
            var myConfig = new Dictionary<string, string>
            {
                { "HealthChecksUI:HealthChecks:0:Name", "self" },
                { "HealthChecksUI:HealthChecks:0:Uri", "/health" }
            };

            return new ConfigurationBuilder()
                .AddInMemoryCollection(myConfig).
                Build();
        }

        public static IConnection GetRabbitMqLocalhostConnection(IServiceProvider serviceProvider)
        {
            return GetRabbitMqConnection(serviceProvider, RabbitMQlocalhostURL);
        }
        public static IConnection GetRabbitMqDockerConnection(IServiceProvider serviceProvider)
        {
            return GetRabbitMqConnection(serviceProvider, RabbitMQDockerURL);
        }

        private static IConnection GetRabbitMqConnection(IServiceProvider serviceProvider, string hostName)
        {
            ConnectionFactory factory = new ConnectionFactory();
            factory.UserName = "guest";
            factory.Password = "guest";
            factory.VirtualHost = "/";
            factory.HostName = hostName;
            return factory.CreateConnection();
        }
    }
}
