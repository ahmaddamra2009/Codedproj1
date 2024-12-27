using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Models
{
    public class Category : Course
    {
        public int CategoryId { get; set; }
        public string CategotyName { get; set; }
        
        public override void CourseDetails()
        {
            
            Console.WriteLine("Category Class: Development" + " , C# Course ");
        }

    }
}
