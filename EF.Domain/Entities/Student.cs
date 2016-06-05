using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Domain.Entities
{
    public class Student : Person
    {
        public Student()
        {
            User = new User();
        }
        public int StudentId { get; set; }
        public virtual Class Class { get; set; }
        public virtual User User { get; set; }
    }
}
