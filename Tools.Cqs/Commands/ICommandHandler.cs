namespace Tools.Cqs.Commands
{
    public interface ICommandHandler<TCommand>
    {
        bool Execute(TCommand command);
    }
}
