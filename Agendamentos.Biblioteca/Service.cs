namespace Agendamentos.Biblioteca;

public class Service
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Service(string name)
    {
        this.Name = name;
    }

    public Service(string name, int id) : this(name)
    {
        this.Id = id;
    }
}
