using CRUD_Operations.Business.Abstract;
using CRUD_Operations.DataAccess.Abstract;
using CRUD_Operations.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Operations.Business.Concrate
{
  public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categorDal;

        public CategoryManager(ICategoryDal categorDal)
        {
            _categorDal = categorDal;
        }

        public List<Category> GetAll()
        {
            return _categorDal.GetAll();
        }
    }
}
