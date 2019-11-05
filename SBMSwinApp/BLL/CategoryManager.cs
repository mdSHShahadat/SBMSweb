using SBMS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBMS.Models;

namespace SBMS.BLL
{
    public class CategoryManager
    {
        CategoryRepository categoryRepository = new CategoryRepository();

        public bool InsertCategory(Category category)
        {

            return categoryRepository.InsertCategory(category);
        }
        public bool UpdateCategory(Category category)
        {

            return categoryRepository.UpdateCategory(category);
        }
        public List<Category> ShowCategory()
        {
            return categoryRepository.ShowCategory();
           
        }
        public int IsCategoryExist(Category category)
        {
            return categoryRepository.IsCategoryExist(category);        
        }
        public List<Category> SearchCategory(Category category)
        {
            return categoryRepository.SearchCategory(category);
        }

    }
}
