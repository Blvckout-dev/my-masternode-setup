using System.ComponentModel.DataAnnotations;

namespace Blvckout.MyMasternode.Setup.Options;

public class DatabaseOptions
{
    public const string SECTION = "Database";

    [Required]
    public string ConnectionString { get; set; }  = string.Empty;

    [Required]
    public string DatabaseName { get; set; } = string.Empty;
}