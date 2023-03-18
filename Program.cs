var p = new Person { Name = "Wilson", Id = 10, Surname = "Neto" };

Console.WriteLine($"{p.Id} / {p.Name}");

class Person
{   public required int Id { get; set; }
    public required string Name { get; set; }
    public required string Surname { get; set; }
}