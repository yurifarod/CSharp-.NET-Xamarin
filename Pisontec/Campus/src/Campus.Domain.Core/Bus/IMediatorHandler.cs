using System.Threading.Tasks;
using Campus.Domain.Core.Commands;
using Campus.Domain.Core.Events;


namespace Campus.Domain.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
        Task RaiseEvent<T>(T @event) where T : Event;
    }
}
