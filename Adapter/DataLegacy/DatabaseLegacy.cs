namespace Adapter.DataLegacy;

public static class DatabaseLegacy
{
    public static List<ClientLegacy> GetClients()
    {
        return new List<ClientLegacy>()
        {
            new ClientLegacy
            {
                Id = "C001",
                Name = "Alice Johnson",
                Reg = "RJ-12345",
                Ct = new DateTime(2022, 1, 10),
                Ut = new DateTime(2023, 5, 15),
                Email = "alice.johnson@example.com",
                CreditLimit = 10000.00M,
                Category = "Regular",
                Status = true,
                Sector = "Retail"
            },
            new ClientLegacy
            {
                Id = "C002",
                Name = "Bob Smith",
                Reg = "SP-67890",
                Ct = new DateTime(2021, 3, 20),
                Ut = new DateTime(2023, 6, 25),
                Email = "bob.smith@example.com",
                CreditLimit = 7500.00M,
                Category = "VIP",
                Status = false,
                Sector = "Technology"
            },
            new ClientLegacy
            {
                Id = "C003",
                Name = "Carol Davis",
                Reg = "MG-11223",
                Ct = new DateTime(2020, 7, 5),
                Ut = new DateTime(2023, 8, 10),
                Email = "carol.davis@example.com",
                CreditLimit = 5000.00M,
                Category = "Small Business",
                Status = true,
                Sector = "Manufacturing"
            }
        };
    }
}