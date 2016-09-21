
using System.Linq;


namespace Models
{
    public class Classmember
    {
        public Classmember()
            :base(){

        }
        public int ClassmemberID { get; set; }

        public int? ClassroomID { get; set; }

        public int? StudentID { get; set; }

        public int? Status { get; set; }

        public int? FinancStatus { get; set; }

        public int? Mark { get; set; }

        public virtual Classroom Classroom { get; set; }

        public virtual Student Student { get; set; }

    }
}