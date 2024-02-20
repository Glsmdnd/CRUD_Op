using CRUD_Operations.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Operations.DataAccess.Abstract
{
    public interface ICategoryDal
    {
        List<Category> GetAll();
        void Add(Course category);

        void Update(Course category);
        void Delete(Course category);
        void DeleteById(int id);
    }
}
