using MongoDB.Bson;
using MongoDB.Bson.Serialization.Conventions;

namespace CarrinhoApi.Persistence
{
    public static class MongoDbPersistence
    {
        public static void Configure()
        {
            CartMap.Configure();

            BsonDefaults.GuidRepresentation = GuidRepresentation.CSharpLegacy;

            var pack = new ConventionPack
            {
                new IgnoreExtraElementsConvention(true),
                new IgnoreIfDefaultConvention(true)
            };

            ConventionRegistry.Register("My Solution Convetions", pack, t => true);
        }
    }
}
