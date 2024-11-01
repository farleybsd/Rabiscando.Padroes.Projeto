namespace Com.Padroes.De.Projeto.CQS.Application.Commands;

public class CommandResult
{
    public bool Success { get; }
    public string Message { get; set; }

    public CommandResult(bool success, string message)
    {
        Success = success;
        Message = message;
    }
}