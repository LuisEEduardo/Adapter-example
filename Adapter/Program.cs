using Adapter.AdapterClient;
using Adapter.DataLegacy;

var clientsLegacy = DatabaseLegacy.GetClients();

ITarget target = new Adapter.AdapterClient.Adapter();

var clients = target.GetClients(clientsLegacy);

Console.WriteLine("------- x ------- x -------");
Console.WriteLine("Clients Data:");
foreach (var client in clients) 
    Console.WriteLine(client.ToString());
Console.WriteLine("------- x ------- x -------");