namespace ClassWork.Lesson11;

public class Customer
{
    public int Id { get; }
    public string Name { get; }
    public string LastName { get; }

    public Customer(int id, string name, string lastName)
    {
        Id = id;
        Name = name;
        LastName = lastName;
    }

    public override int GetHashCode()
    {
        var hashCode = Id;
        foreach (var letter in Name)
        {
            hashCode += Convert.ToInt32(letter);
        }

        return hashCode;
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Customer)
        {
            throw new ArgumentException("Can only compare two Customers");
        }
        var otherCustomer = (Customer)obj;

        if (GetHashCode() != otherCustomer.GetHashCode())
        {
            return false;
        }

        return Id == otherCustomer.Id && Name == otherCustomer.Name && LastName == otherCustomer.LastName;
    }

    public override string ToString()
    {
        return $"Customer Id:{Id} Name:{Name}";
    }
}