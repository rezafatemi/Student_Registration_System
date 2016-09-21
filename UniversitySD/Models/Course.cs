
using System.Linq;

namespace Models
{
    public class Course
    {
        public Course()
            :base(){

        }
        public int CourseID { get; set; }

        public int? MajorsID { get; set; }

        public string Name { get; set; }

        public int? Unit { get; set; }

        public decimal? Fee { get; set; }

        public virtual System.Collections.Generic.IList<Classroom> Classrooms { get; set; }

        public virtual Major Major { get; set; }

    }
}