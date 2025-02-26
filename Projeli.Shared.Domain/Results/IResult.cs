﻿namespace Projeli.WikiService.Domain.Results;

public interface IResult<out T>
{
    T? Data { get; }
    bool Success { get; }
    string? Message { get; set; }
    Dictionary<string, string[]> Errors { get; set; }
    
    public bool Failed => !Success;
}