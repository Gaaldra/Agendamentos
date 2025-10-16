namespace Agendamentos.Biblioteca;

public class Service
{
    public int ID { get; set; }
    public string Name { get; set; }

    public Service(string name)
    {
        this.Name = name;
    }

    public Service(string name, int id) : this(name)
    {
        this.ID = id;
    }
}
