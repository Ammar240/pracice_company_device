namespace IEnumerableProject;

internal class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public string Department { get; set; }

    public override bool Equals(object? obj)
    {
        if (obj is null || obj is not Employee)
            return false;

        Employee other = obj as Employee;
        return Id == other.Id
            && Name == other.Name
            && Salary == other.Salary
            && Department == other.Department;

    }

    //override == operator
    public static bool operator ==(Employee left, Employee right) => left.Equals(right);
    public static bool operator !=(Employee left, Employee right) => !left.Equals(right);

    //override GetHashCode()
    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Name, Salary, Department);
    }
}
