﻿using System.ComponentModel.DataAnnotations.Schema;
using DataAccess.Enums;

namespace DataAccess.Models;

public class Entity
{
    [Column("id")]
    public Guid Id { get; set; }

    [Column("created_date")]
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

    [Column("updated_date")]
    public DateTime? UpdatedDate { get; set; }

    [Column("state")]
    public EntityStatus State { get; set; }
}