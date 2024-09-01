using AcademyApp.Application.Interfaces;
using AcademyApp.Core.Entities;
using AcademyApp.Data.Data;

namespace AcademyApp.Application.Implementations
{
    public class StudentService : IStudentService
    {
        private readonly AcademyAppContext _appContext;

        public StudentService(AcademyAppContext appContext)
        {
            _appContext = appContext;
        }

        public List<Student> GetAll()
        {
            return _appContext.Students.ToList();
        }
    }
}
