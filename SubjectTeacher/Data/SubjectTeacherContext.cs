using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SubjectTeacher.Models;

namespace SubjectTeacher.Data
{
    public class SubjectTeacherContext : DbContext
    {
        public SubjectTeacherContext (DbContextOptions<SubjectTeacherContext> options)
            : base(options)
        {
        }

        public DbSet<SubjectTeacher.Models.Subject> Subject { get; set; } = default!;

        public DbSet<SubjectTeacher.Models.Teacher> Teacher { get; set; }
    }
}
