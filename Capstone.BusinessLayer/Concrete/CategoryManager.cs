using Capstone.BusinessLayer.Abstract;
using Capstone.DataAccessLayer.Abstract;
using Capstone.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _CategoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _CategoryDal = categoryDal;
        }

        public void TDelete(Category t)
        {
            _CategoryDal.Delete(t); 
        }

        public Category TGetById(int id)
        {
            return _CategoryDal.GetById(id);
        }

        public List<Category> TGetList()
        {
            return _CategoryDal.GetList();
        }

        public void TInsert(Category t)
        {
         _CategoryDal.Insert(t);   
        }

        public void TUpdate(Category t)
        {
            _CategoryDal.Update(t);
        }
    }
}
