namespace EmployeeWebAPI.Models
{
    public interface IEmployee
    {
        int Age { get; set; }
        int Id { get; set; }
        string Name { get; set; }
        string NickName { get; set; }
    }
}