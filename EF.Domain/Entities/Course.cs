using System.Collections.Generic;

namespace EF.Domain.Entities
{
    public class Course
    {
        public Course()
        {
            Teachers = new List<Teacher>();
            Active = true;
        }
        public int CourseId { get; set; }
        public string Number { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Teacher> Teachers  { get; set; }
        public override string ToString()
        {
            return Description;
        }
    }
}