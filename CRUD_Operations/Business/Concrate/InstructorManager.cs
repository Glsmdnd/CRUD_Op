using CRUD_Operations.Business.Abstract;
using CRUD_Operations.DataAccess.Abstract;
using CRUD_Operations.DataAccess.Concretes;
using CRUD_Operations.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Operations.Business.Concrate
{
    public class InstructorManager: IInstructorService
    {
        private readonly IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }

       
    }
}
