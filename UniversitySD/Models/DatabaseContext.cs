
using System.Data.Entity;
using System.Linq;


namespace Models
{
    public class DatabaseContext : DbContext
    {

        public virtual DbSet<Classmember> Classmembers { get; set; }
        public virtual DbSet<Classroom> Classrooms { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Financial> Financials { get; set; }
        public virtual DbSet<Lecture> Lectures { get; set; }
        public virtual DbSet<Major> Majors { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Term> Terms { get; set; }

    }
}