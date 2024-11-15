using Adapter.DataLegacy;
using Adapter.Entities;

namespace Adapter.AdapterClient;

public interface ITarget
{
    List<Client> GetClients(List<ClientLegacy> clientLegacies);
}