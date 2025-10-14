namespace Agendamentos.Biblioteca;

public class Client : User
{
    public bool CanReceiveEmail { get; set; } = false;

    public Client() : base() { }
    public Client(string name, string email, string phone, DateOnly birth, bool canReceiveEmail) : base(name, email, phone, birth)
    {
        this.CanReceiveEmail = canReceiveEmail;
    }

    public Client(string name, string email, string phone, DateOnly birth, bool canReceiveEmail, Address address, string description, int id) : base(name, email, phone, birth, address, description, id)
    {
        this.CanReceiveEmail = canReceiveEmail;
    }

}
// github.com/Gaaldra/modelos