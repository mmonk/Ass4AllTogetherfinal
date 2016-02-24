﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ass4AllTogether.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }

        [Display(Name ="Course Name:")]
        public string CourseName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}