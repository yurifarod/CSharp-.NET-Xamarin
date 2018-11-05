using System.Threading.Tasks;

namespace Campus.Infra.CrossCutting.Identity.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
