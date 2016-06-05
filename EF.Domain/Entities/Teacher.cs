using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EF.Domain.Entities
{
    public class Teacher : Person
    {
        public Teacher()
        {
            Courses = new List<Course>();
            Classes =new List<Class>();
        }
        public int TeacherId { get; set; }
        public virtual ICollection<Class> Classes  { get; set; }
        public virtual ICollection<Course> Courses  { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }

    
}