using CRUD_Operations.Business.Concrate;
using CRUD_Operations.DataAccess.Abstract;
using CRUD_Operations.DataAccess.Concretes;
using CRUD_Operations.Entities.Concrate;


{
    CourseManager courseManager = new CourseManager(new CourseDal());
    Console.WriteLine("Mevcut Kurslarımız:");
    foreach (var course in courseManager.GetAll())
        {
            Console.WriteLine(course.CourseName);
        }
    //Comment
   Console.WriteLine("\n---------------------------------------------------\n");
    Console.WriteLine("Mevcut Kategorilerimiz:");
    CategoryManager categoryManager = new CategoryManager(new CategoryDal());
        foreach (var category in categoryManager.GetAll())
        {
            Console.WriteLine(category.CategoryName);
        }
Console.WriteLine("\n---------------------------------------------------\n");
    Console.WriteLine("Mevcut Hocalarımız:");
    InstructorManager instructorManager = new InstructorManager(new InstructorDal());
foreach (var instructor in instructorManager.GetAll())
{
    Console.WriteLine($"{instructor.Name}  ");
}
}