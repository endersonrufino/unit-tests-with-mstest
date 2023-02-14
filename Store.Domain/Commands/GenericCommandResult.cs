using Store.Domain.Commands.Interfaces;

namespace Store.Domain.Commands
{
    public class GenericCommandResult : ICommandResult
    {
        public GenericCommandResult(bool success, string message, object data)
        {
            Success = success;
            Message = message;
            this.data = data;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
        public object data { get; set; }        
    }
}