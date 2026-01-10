using System.Text.Json;
class _58_User
{
    public int Id { get; set; }
    public string Name { get; set; }
}
class _58_Program
{
    public void Main()
    {
        _58_User user = new _58_User { Id = 1, Name = "Alice" };

        string json = JsonSerializer.Serialize(user);
        File.WriteAllText("user.json", json);
        Console.WriteLine("User Serialized Successfully");


        _58_User user1 = JsonSerializer.Deserialize<_58_User>(json);
        Console.WriteLine($"User Loaded ::>> {user1.Id},  {user1.Name}");
    }
}