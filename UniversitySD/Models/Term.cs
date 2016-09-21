using System.Linq;


namespace Models
{
    public class Term
    {
        public Term()
            :base(){

        }
        public int TermID { get; set; }

        public string Title { get; set; }

        public virtual System.Collections.Generic.IList<Classroom> Classrooms { get; set; }

        public virtual System.Collections.Generic.IList<Financial> Financials { get; set; }

    }
}