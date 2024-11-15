using Adapter.DataLegacy;
using Adapter.Entities;

namespace Adapter.AdapterClient;

public class Adapter : ITarget
{
    public List<Client> GetClients(List<ClientLegacy> clientLegacies)
    {
        if (clientLegacies == null || clientLegacies.Count == 0) return [];
        
        return clientLegacies.Select(clientLegacy => 
            new Client(clientLegacy.Id,
                clientLegacy.Name,
                clientLegacy.Reg,
                clientLegacy.Ct,
                clientLegacy.Ut,
                clientLegacy.Email))
            .ToList();
    }
}