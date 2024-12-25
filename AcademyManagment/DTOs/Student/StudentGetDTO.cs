namespace AcademyManagment.DTOs.Student;

public class StudentGetDTO
{
    public string FullName { get; set; }
    public string Email { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime EnrolmentDate { get; set; }
    public int GroupId { get; set; }
}
