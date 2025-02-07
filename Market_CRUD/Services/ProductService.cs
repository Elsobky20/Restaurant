
using Business.Models;
using Market_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class ProductService
    {
        AppDbContext dbContext;
        public ProductService()
        {
            dbContext = new AppDbContext();
        }

        public List<ProductVM> getProducts()
        {
            return (from p in dbContext.Products
                    join c in dbContext.Categories on p.categoryId equals c.Id
                    select new ProductVM
                    {
                        Name = p.Name,
                        Price = p.Price,
                        Ctg_Name = c.Name,
                        Ctg_Id = c.Id,
                        ID = p.Id
                    }).ToList();
        }

        public int DeleteProduct(int Id)
        {
            var product = dbContext.Products.FirstOrDefault(p => p.Id == Id);

            if (product != null)
            {
                dbContext.Products.Remove(product);
                return dbContext.SaveChanges();
            }

            return 0; 
        }

        public int AddProduct(ProductVM productVM)
        {
            var product = new Product
            {
                Name = productVM.Name,
                Price = productVM.Price,
                categoryId = productVM.Ctg_Id
            };

            dbContext.Products.Add(product);
            return dbContext.SaveChanges(); 
        }
        public int UpdateProduct(ProductVM productVM)
        {
            var product = dbContext.Products.FirstOrDefault(p => p.Id == productVM.ID);

            if (product != null)
            {
                product.Name = productVM.Name;
                product.Price = productVM.Price;
                product.categoryId = productVM.Ctg_Id;

                return dbContext.SaveChanges();
            }

            return 0; 
        }

        public List<ProductVM> getProductCategort(string Ctg_Name)
        {
            return (from p in dbContext.Products
                    join c in dbContext.Categories on p.categoryId equals c.Id
                    where c.Name.StartsWith(Ctg_Name)
                    select new ProductVM
                    {
                        Name = p.Name,
                        Ctg_Name = c.Name,
                        ID = p.Id,
                        Price=p.Price
                    }).ToList();
        }

        public int AddProductFavourite(int User_Id, int Prod_Id)
        {
            if (User_Id !=0 &&Prod_Id !=0 )
            {
                var userProduct = new UserProduct
                {
                    UserId = User_Id,
                    ProductId = Prod_Id
                };

                dbContext.UserProducts.Add(userProduct);
                return dbContext.SaveChanges();
            }
           return -1;
        }



        public int DeleteProductFavourite(int User_Id, int Prod_Id)
        {
            if (User_Id != 0 && Prod_Id != 0)
            {
                var userProduct = dbContext.UserProducts.FirstOrDefault(up => up.UserId == User_Id && up.ProductId == Prod_Id);

                if (userProduct != null)
                {
                    dbContext.UserProducts.Remove(userProduct);
                    return dbContext.SaveChanges();
                }
            }
            return 0; 
        }

        public ProductVM getOneProduct(int Prod_Id)
        {
            return (from p in dbContext.Products
                    join c in dbContext.Categories on p.categoryId equals c.Id
                    where p.Id == Prod_Id
                    select new ProductVM
                    {
                        Name = p.Name,
                        Ctg_Name = c.Name,
                        ID = p.Id
                    }).FirstOrDefault();
        }

        public List<ProductVM> getFavProduct(int User_Id)
        {
            return (from up in dbContext.UserProducts
                    join p in dbContext.Products on up.ProductId equals p.Id
                    join c in dbContext.Categories on p.categoryId equals c.Id
                    where up.UserId == User_Id
                    select new ProductVM
                    {
                        Name = p.Name,
                        Ctg_Name = c.Name,
                        ID = p.Id ,
                        Price = p.Price,
                    }).Distinct().ToList();
        }

    }
}
