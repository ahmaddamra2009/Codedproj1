﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Models
{
    public class Course
    {

        public int Id { get; set; }
        public string CourseName { get; set; }

      
        public virtual void CourseDetails() 
        {
            Console.WriteLine("Course Class: Default Value");
        }
    }
}
