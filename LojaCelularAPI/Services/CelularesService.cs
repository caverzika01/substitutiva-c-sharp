using LojaCelularAPI.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace LojaCelularAPI.Services
{
    public class CelularesService
    {
        private readonly IMongoCollection<Celulares> _celularesCollection;

        public CelularesService(
            IOptions<LojaCelularDatabaseSettings> lojaCelularDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                lojaCelularDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                lojaCelularDatabaseSettings.Value.DatabaseName);

            _celularesCollection = mongoDatabase.GetCollection<Celulares>(
                lojaCelularDatabaseSettings.Value.CelularesCollectionName);
        }

        public async Task<List<Celulares>> GetAsync() =>
            await _celularesCollection.Find(_ => true).ToListAsync();

        public async Task<Celulares?> GetAsync(string id) =>
            await _celularesCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Celulares newCelular) =>
            await _celularesCollection.InsertOneAsync(newCelular);

        public async Task UpdateAsync(string id, Celulares updateCelular) =>
            await _celularesCollection.ReplaceOneAsync(x => x.Id == id, updateCelular);

        public async Task RemoveAsync(string id) =>
            await _celularesCollection.DeleteOneAsync(x => x.Id == id);
    }
}
