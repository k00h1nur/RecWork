﻿namespace Domain.Models.Options;

public record JwtOptions
{
    public static string SectionName = "Jwt";
    public string Key { get; init; } = string.Empty;
    public string Issuer { get; init; } = string.Empty;
    public string Audience { get; init; } = string.Empty;
    public int ExpirationInMinutes { get; init; }
}