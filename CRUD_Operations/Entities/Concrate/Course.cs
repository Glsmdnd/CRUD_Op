using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Operations.Entities.Concrate
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public Instructor Instructor { get; set; }
        public Category Category { get; set; }
        public int Price { get; set; }
    }
}
