using CRUD_Operations.DataAccess.Abstract;
using CRUD_Operations.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Operations.DataAccess.Concretes
{
    public class CourseDal:ICourseDal
    {
        List<Course> _courses;
        public CourseDal()
        {
            var inst = new Instructor() { Id = 1, Name = "Engin Demiroğ" };
            var category = new Category() { CategoryId = 1, CategoryName = "frontend" };
            _courses = new List<Course> {
        new Course { Id = 1, CourseName = "C#", Description = "Yazılım geliştirme",Instructor = inst,Category=category,Price=5},
        new Course { Id = 2, CourseName = "Python", Description = "Veri bilimi ve yapay zeka",Instructor = inst,Category=category,Price=5 },
        new Course { Id = 3, CourseName = "JavaScript", Description = "Web geliştirme",Instructor = inst,Category=category,Price=5 },
    };
        }
        
        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public void Delete(Course course)
        {
            _courses.Remove(course);
        }

        public void DeleteById(int id)
        {
            _courses.Remove(_courses.SingleOrDefault(x => x.Id == id));
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public void Update(Course course)
        {
            Course updatedCourse = new Course();
            updatedCourse.Id = course.Id;
            updatedCourse.CourseName = course.CourseName;
            updatedCourse.Description = course.Description;
            updatedCourse.Instructor = course.Instructor;
            updatedCourse.Category = course.Category;
            updatedCourse.Price = course.Price;


    }
    }
}
