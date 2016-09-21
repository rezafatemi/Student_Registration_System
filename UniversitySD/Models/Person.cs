
using System;
using System.Linq;

namespace Models
{
    public class Person
    {
        public Person()
            :base(){

        }
        public int PersonID { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public DateTime? Birthday { get; set; }

        public string NationCode { get; set; }

        public virtual System.Collections.Generic.IList<Lecture> Lectures { get; set; }

        public virtual System.Collections.Generic.IList<Student> Students { get; set; }

    }
}