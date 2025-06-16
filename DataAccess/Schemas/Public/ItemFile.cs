using System.ComponentModel.DataAnnotations.Schema;
using DataAccess.Enums;
using DataAccess.Models;

namespace DataAccess.Schemas.Public;

[Table("item_files")]
public class ItemFile : Entity
{
    [Column("item_id")]
    public Guid ItemId { get; set; }

    [Column("location")]
    public string Location { get; set; }

    [Column("extension")]
    public string Extension { get; set; }

    [Column("type")]
    public ItemFileType Type { get; set; }

    [Column("original_name")]
    public string OriginalName { get; set; }

    [Column("size")]
    public long Size { get; set; }
}