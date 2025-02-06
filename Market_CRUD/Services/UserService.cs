using Business.Models;
using Dapper;
using Market_CRUD.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Services
{
    public class UserService
    {
        AppDbContext dbContext;
        public UserService()
        {
            dbContext = new AppDbContext();
        }

        public int Register(UserVM user)
        {
            var newUser = new User
            {
                Name = user.Name,
                Email = user.Email,
                Password = user.Password,
                Role = "User" 
            };

            dbContext.Users.Add(newUser);
            return dbContext.SaveChanges(); 
        }

        public User Login(UserVM user)
        {
            return dbContext.Users.FirstOrDefault(u => u.Email == user.Email && u.Password == user.Password);
        }

        public List<UserVM> GetAllUsers()
        {
            return dbContext.Users.Select(u => new UserVM
            {
                Name = u.Name,
                Email = u.Email,
                Password = u.Password,
            }).ToList();
        }


        public UserVM GetUserById(int id)
        {
            using (var connection = new SqlConnection("Data Source=.;Initial Catalog=EF-Markert;Integrated Security=True;Encrypt=False"))
            {
                string sql = @"
            SELECT Name, Email, Password
            FROM Users
            WHERE Id = @Id";

                connection.Open();

                var user = connection.QueryFirstOrDefault<UserVM>(sql, new { Id = id });

                return user;
            }
        }
        //public UserVM GetUserById(int id)
        //{
        //    var user = dbContext.Users.FirstOrDefault(u => u.Id == id);

        //    if (user != null)
        //    {
        //        return new UserVM
        //        {
        //            Name = user.Name,
        //            Email = user.Email,
        //            Password = user.Password ,
        //        };
        //    }

        //    return null; 
        //}

        public int UpdateUser(UserVM userVM)
        {
            var user = dbContext.Users.FirstOrDefault(u => u.Id == userVM.ID);

            if (user != null)
            {
                user.Name = userVM.Name;
                user.Email = userVM.Email;
                user.Password = userVM.Password;

                return dbContext.SaveChanges(); 
            }

            return 0; 
        }

        public int DeleteUser(int id)
        {
            var user = dbContext.Users.FirstOrDefault(u => u.Id == id);

            if (user != null)
            {
                dbContext.Users.Remove(user);
                return dbContext.SaveChanges(); 
            }

            return 0; 
        }




    }
}
