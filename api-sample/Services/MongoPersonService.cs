using api_sample.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_sample.Services
{
    public class MongoPersonService:IPersonService
    {
        private MongoClient _client;
        private IMongoDatabase _db;

        public MongoPersonService()
        {
            _client = new MongoClient(Environment.GetEnvironmentVariable("MONGO_URL"));
            _db = _client.GetDatabase("person");
        }

        public List<PersonModel> ListAllPerson()
        {
            IMongoCollection<PersonModel> collection = _db.GetCollection<PersonModel>("person");
            List<PersonModel> persons = collection.AsQueryable<PersonModel>().ToList();
            return persons;
        }
    }
}
