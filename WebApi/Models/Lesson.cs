using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public string LessonName { get; set; }
        public int Price { get; set; }
        public int Duration { get; set; }
    }
}
