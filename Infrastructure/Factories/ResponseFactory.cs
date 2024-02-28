

using Infrastructure.Models;

namespace Infrastructure.Factories;

public class ResponseFactory
{
    public static ResponsResult Ok()
    {
        return new ResponsResult
        {
            
            Message = "Succeeded",
            StatusCode = StatusCode.OK
        };
    }

    public static ResponsResult Ok(string? message = null)
    {
        return new ResponsResult
        { 
            Message = message ?? "Succeeded",
            StatusCode = StatusCode.OK
        };
    }

    public static ResponsResult Ok(object obj, string? message = null)
    {
        return new ResponsResult
        {
            ContentResult = obj,
            Message = message ?? "Succeeded",
            StatusCode = StatusCode.OK
        };
    }




    public static ResponsResult Error(string? message = null)
    {
        return new ResponsResult
        {

            Message = message ?? "Failed", 
            StatusCode = StatusCode.ERROR
        };
    }


    public static ResponsResult Exists(string? message = null)
    {
        return new ResponsResult
        {

            Message = message ?? "Already exists",
            StatusCode = StatusCode.EXISTS
        };
    }



    public static ResponsResult NotFound(string? message = null)
    {
        return new ResponsResult
        {

            Message = message ?? "Not found",
            StatusCode = StatusCode.NOT_FOUND
        };
    }
}
