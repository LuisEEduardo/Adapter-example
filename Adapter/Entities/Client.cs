namespace Adapter.Entities;

public class Client
{
    public string Id { get; private set; }
    public string Name { get; private set; }
    public string Registration { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }
    public string Email { get; private set; }

    public Client(string id, string name, string registration, DateTime createdAt, DateTime updatedAt, string email)
    {
        Id = id;
        Name = name;
        Registration = registration;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
        Email = email;
    }

    public override string ToString() =>
        $"name: {Name}, registration: {Registration}, created: {CreatedAt}, updated: {UpdatedAt}";
}