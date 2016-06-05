using System;
using System.Collections.Generic;

namespace EF.Domain.Entities
{
    public class Class
    {
        public int ClassId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Course Course { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public override string ToString()
        {
            return String.Format("Class: {0} - Start Date: {1} - Teacher: {2}", Course.Description,
                StartDate.ToShortDateString(), Teacher.Name);
        }
    }
}