namespace Agendamentos.Biblioteca;

public class Address
{
    public int ID { get; set; }
    public string Street { get; set; }
    public string Number { get; set; }
    public string? Complement { get; set; }
    public string Neighborhood { get; set; }
    public string City { get; set; }
    public string ZIPCode { get; set; }

    public Address(string street, string number, string neighborhood, string city, string zipCode)
    {
        this.Street = street;
        this.Number = number;
        this.Neighborhood = neighborhood;
        this.City = city;
        this.ZIPCode = zipCode;
    }

    public Address(string street, string number, string neighborhood, string city, string zipCode, string complement, int id) : this(street, number, neighborhood, city, zipCode)
    {
        this.Complement = complement;
        this.ID = id;
    }
}