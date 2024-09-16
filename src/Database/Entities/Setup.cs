using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Blvckout.MyMasternode.Setup.Database.Entities;

public class Setup
{
    [BsonId]
    public ObjectId Id { get; set; }
    
    public int MasternodeId { get; set; }
    
    public int IssuerId { get; set; }

    public int OwnerId { get; set; }

    public string? WalletAddress { get; set; }

    public string? MasternodeKey { get; set; }

    public string? Ip { get; set; }

    public int Status { get; set; }
}