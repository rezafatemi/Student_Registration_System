
using System.Linq;

namespace Models
{
    public class Student
    {
        public Student()
            :base(){

        }
        public int StudentID { get; set; }

        public int? PersonID { get; set; }

        public int? EnYear { get; set; }

        public virtual System.Collections.Generic.IList<Classmember> Classmembers { get; set; }

        public virtual System.Collections.Generic.IList<Financial> Financials { get; set; }

        public virtual Person Person { get; set; }

    }
}