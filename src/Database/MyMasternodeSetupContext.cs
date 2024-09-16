using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Blvckout.MyMasternode.Setup.Database;

public class MyMasternodeSetupContext
{
    private readonly IOptionsMonitor<Options.DatabaseOptions> _databaseOptions;
    private readonly IMongoDatabase _database;

    public MyMasternodeSetupContext(IOptionsMonitor<Options.DatabaseOptions> databaseOptions)
    {
        _databaseOptions = databaseOptions;

        var client = new MongoClient(_databaseOptions.CurrentValue.ConnectionString);
        _database = client.GetDatabase(_databaseOptions.CurrentValue.DatabaseName);
    }

    public IMongoCollection<Entities.Setup> Setups => _database.GetCollection<Entities.Setup>("setups");
}