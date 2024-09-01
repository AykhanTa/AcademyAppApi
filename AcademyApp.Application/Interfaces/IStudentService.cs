using AcademyApp.Core.Entities;

namespace AcademyApp.Application.Interfaces
{
    public interface IStudentService
    {
        List<Student> GetAll();
    }
}
