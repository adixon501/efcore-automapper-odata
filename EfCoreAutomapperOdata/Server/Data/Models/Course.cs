﻿using System.Collections.Generic;

namespace EfCoreAutomapperOdata.Server.Data.Models
{
    public class Course
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Instructor Instructor { get; set; }

        public ICollection<CourseStudent> Students { get; set; }
    }
}
