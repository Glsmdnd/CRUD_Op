using CRUD_Operations.DataAccess.Abstract;
using CRUD_Operations.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Operations.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {

        List<Category> _categories;
        public CategoryDal()
        {
            _categories = new List<Category>
        {
            new Category
            { CategoryId = 1,
              CategoryName = "Backend Development" },
            new Category
            { CategoryId = 2,
              CategoryName = "Frontend Development" },

        };
        }
        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Add(Course category)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category category)
        {
            _categories.Remove(category);
        }

        public void Delete(Course category)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            _categories.Remove(_categories.SingleOrDefault(x => x.CategoryId == id));
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }

        public void Update(Course category)
        {
            throw new NotImplementedException();
        }

    }
}
