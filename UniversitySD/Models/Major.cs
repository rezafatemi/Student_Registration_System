
using System.Linq;


namespace Models
{
    public class Major
    {
        public Major()
            :base(){

        }
        public int MajorsID { get; set; }

        public int? DepartmentID { get; set; }

        public string Name { get; set; }

        public virtual System.Collections.Generic.IList<Course> Courses { get; set; }

        public virtual Department Department { get; set; }

    }
}