namespace AcademyManagment.Entities;

public class Student : BaseEntity
{
    public string FullName { get; set; }
    public string Email { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime EnrolmentDate { get; set; }
    public int GroupId { get; set; }
    public Group Group { get; set; }
}
