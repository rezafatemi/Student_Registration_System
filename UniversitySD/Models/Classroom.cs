using System.Linq;

namespace Models
{
    public class Classroom
    {
        public Classroom()
            : base(){

        }
        public int ClassroomID { get; set; }

        public int? CourseID { get; set; }

        public int? TermID { get; set; }

        public int? LectureID { get; set; }

        public string Day { get; set; }

        public System.DateTime? Time { get; set; }

        public string Location { get; set; }

        public int? Unit { get; set; }

        public decimal? Fee { get; set; }

        public virtual System.Collections.Generic.IList<Classmember> Classmembers { get; set; }

        public virtual Course Course { get; set; }

        public virtual Lecture Lecture { get; set; }

        public virtual Term Term { get; set; }

    }
}