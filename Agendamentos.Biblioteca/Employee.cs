namespace Agendamentos.Biblioteca;

public class Employee : User
{
    public string Password { get; set; }
    public Role Role { get; set; } // Quando pegar o funcionario, precisa pegar a informação na tabela cargos
    public int RoleID { get; set; }

    public Employee() { }
    public Employee(string name, string email, string phone, DateOnly birth, string password, Role role) : base(name, email, phone, birth)
    {
        this.Password = password;
        this.Role = role;
    }

    public Employee(string name, string email, string phone, DateOnly birth,string password, Role role, Address address, string description, int id) : base(name, email, phone, birth, address, description, id)
    {
        this.Password = password;
        this.Role = role;
    }

}
