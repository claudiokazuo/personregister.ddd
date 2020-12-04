﻿using Shared.Commands;

namespace Application.Commands.Response
{
    public class GenericResponseCommand : IResponseCommand
    {
        public GenericResponseCommand(bool success, string message, object data)
        {
            Success = success;
            Message = message;
            Data = data;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
