﻿namespace Application.Responses;

public class BaseResponse
{
    public BaseResponse()
    {
        Success = true;
    }

    public BaseResponse(string message)
    {
        Success = true;
        Message = message;
    }

    public BaseResponse(string message, bool success)
    {
        Success = success;
        Message = message;
    }
    public BaseResponse(List<string> errors)
    {
        ValidationErrors = errors;
        Success = false;
    }
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public List<string> ValidationErrors { get; set; }
}