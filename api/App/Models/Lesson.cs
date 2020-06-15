using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace App.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public int No { get; set; }
        public string Title { get; set; }
        public string Thumbnail { get; set; }
        public string Content { get; set; }

        // Foreign keys
        public int CourseId { get; set; }
        public Course Course { get; set; }

        // Foreign items
        public virtual ICollection<LessonDetail> LessonDetails { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
