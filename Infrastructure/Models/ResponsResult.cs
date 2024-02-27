namespace Infrastructure.Models;

public enum StatusCode
{
    OK = 200,
    ERROR = 400,
    NOT_FOUND = 404,
    EXISTS = 409
}



public class ResponsResult
{
    public StatusCode SatusCode { get; set; }
    public object? ContentResult { get; set; }
    public string? Message { get; set; }
}
