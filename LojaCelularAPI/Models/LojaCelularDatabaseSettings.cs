namespace LojaCelularAPI.Models
{
    public class LojaCelularDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string CelularesCollectionName { get; set; } = null!;
    }
}
