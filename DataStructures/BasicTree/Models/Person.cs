namespace BasicTree.Models;

public class Person
{
    public Person()
    {
    }

    public Person(int id, string name, string role)
    {
        Id = id;
        Name = name;
        Role = role;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Role { get; set; }
}