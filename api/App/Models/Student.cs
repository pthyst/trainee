using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string FacebookUrl { get; set; }
        public double Points { get; set; } = 0.0;

        // Foreign keys
        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }

        // Foreign items
        public virtual ICollection<LessonDetail> LessonDetails { get; set; }
        public virtual ICollection<TeamDetail> TeamDetails { get; set; }
    }
}
