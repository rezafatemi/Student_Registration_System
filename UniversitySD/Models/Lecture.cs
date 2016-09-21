
using System.Linq;


namespace Models
{
    public class Lecture
    {
        public Lecture()
            : base()
        {
            
        }
        public int LectureID { get; set; }

        public int? PersonID { get; set; }

        public System.DateTime? StartColl { get; set; }

        public virtual System.Collections.Generic.IList<Classroom> Classrooms { get; set; }

        public virtual Person Person { get; set; }

    }
}