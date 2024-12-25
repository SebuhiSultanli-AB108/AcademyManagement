namespace AcademyManagment.Entities;

public class Teacher : BaseEntity
{
    public string FullName { get; set; }
    public string Email { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string PhoneNumber { get; set; }
    public int Salary { get; set; }
    public int GroupId { get; set; }
    public Group Group { get; set; }
}
