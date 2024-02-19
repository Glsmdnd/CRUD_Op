using CRUD_Operations.DataAccess.Abstract;
using CRUD_Operations.Entities.Concrate;
namespace CRUD_Operations.DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;
        public InstructorDal()
        {
            _instructors = new List<Instructor>
        {
            new Instructor
        {
            Id = 1,
            Name = "Engin",
            

        },

        new Instructor
        {
            Id = 2,
            Name = "Ayşe",
       
           },
        };
        }
        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Add(Course instructor)
        {
            throw new NotImplementedException();
        }

        public void Delete(Instructor instructor)
        {
            _instructors.Remove(instructor);
        }

        public void Delete(Course instructor)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            _instructors.Remove(_instructors[id]);
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public void Update(Instructor instructor)
        {
            throw new NotImplementedException();
        }

        public void Update(Course instructor)
        {
            throw new NotImplementedException();
        }

        
    }
}
