
using System.Linq;

namespace Models
{
    public class Financial
    {
        public Financial()
            :base(){

        }
        public int FinancialID { get; set; }

        public int TermID { get; set; }

        public int StudentID { get; set; }

        public decimal Total { get; set; }

        public decimal Pay { get; set; }

        public int Status { get; set; }

        public virtual Student Student { get; set; }

        public virtual Term Term { get; set; }

    }
}