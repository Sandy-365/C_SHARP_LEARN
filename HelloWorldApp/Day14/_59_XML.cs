using System.Xml.Serialization;
public class _59_User
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class _59_Program
{
    public void Main()
    {
        _59_User user = new _59_User { Id = 1, Name = "Alice" };

        Console.WriteLine(typeof(_59_User));
        XmlSerializer serializer = new XmlSerializer(typeof(_59_User));

        using (FileStream fs = new FileStream("Day14/_59_user.xml", FileMode.Create))
        {
            serializer.Serialize(fs, user);
        }

        Console.WriteLine("XML Serialized");
    }
}