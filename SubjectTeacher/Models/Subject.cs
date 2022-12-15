using System.ComponentModel.DataAnnotations;

namespace SubjectTeacher.Models
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }
        public string? SunbjectName { get; set; }
        public string? SubjectTerm { get; set; }
        public int SubjectCredits { get; set; }

        public List<Teacher> SubjectTeachers { get; set; } = new List<Teacher>();
    }
}
