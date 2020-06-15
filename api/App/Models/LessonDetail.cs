using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    public class LessonDetail
    {
        public long Id { get; set; }
        public double Points { get; set; } = 0.0;

        // Foreign keys
        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
