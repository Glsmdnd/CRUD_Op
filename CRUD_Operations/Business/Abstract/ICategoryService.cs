using CRUD_Operations.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Operations.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
