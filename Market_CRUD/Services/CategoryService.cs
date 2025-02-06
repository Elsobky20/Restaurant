
using Business.Models;
using Market_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace Business.Services
{
    public class CategoryService
    {
        AppDbContext dbContext;
        public CategoryService()
        {
            dbContext = new AppDbContext();
        }
        public List<Category> getCategory()
        {

            return dbContext.Categories.ToList();
        }
        public int DeleteCategory(int Id)
        {
        
            var deletedData = dbContext.Categories.FirstOrDefault(c => c.Id == Id);

            if (deletedData != null)
            {
                dbContext.Categories.Remove(deletedData);
                return dbContext.SaveChanges();
            }

            return 0; 
        }
        
       public int AddCategory(CategoryVM categoryVM)
        {
            var category = new Category
            {
                Name = categoryVM.Name,
                Description = categoryVM.Description
            };

            dbContext.Categories.Add(category);
            return dbContext.SaveChanges(); 
        }
        public int UpdateCategory(CategoryVM categoryVM)
        {
            var category = dbContext.Categories.FirstOrDefault(c => c.Id == categoryVM.ID);

            if (category != null)
            {
                category.Name = categoryVM.Name;
                category.Description = categoryVM.Description;

                return dbContext.SaveChanges(); 
            }

            return 0; 
        }

    }
}
