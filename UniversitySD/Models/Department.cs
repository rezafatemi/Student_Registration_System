
using System.Linq;


namespace Models
{
    public class Department
    {
        public Department()
            : base(){

        }
        public int DepartmentID { get; set; }

        public string Name { get; set; }

        public string Tel { get; set; }

        public virtual System.Collections.Generic.IList<Major> Majors { get; set; }

    }
}