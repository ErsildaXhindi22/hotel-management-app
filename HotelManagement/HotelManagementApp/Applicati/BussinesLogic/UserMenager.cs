using HotelManagementApp.Applicati.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementApp.Applicati.BussinesLogic
{
    internal class UserMenager
    {
        public class UserManager
        {
            private List<User> users = new List<User>
        {
            new User { Id = 1, Name = "Admin", Email = "admin@example.com", Password = "admin123", Role = "Admin" },
            new User { Id = 2, Name = "Test User", Email = "user@example.com", Password = "user123", Role = "User" }
        };

            public User LogIn(string email, string password)
            {
                return users.FirstOrDefault(u => u.Email == email && u.Password == password);
            }

            public List<User> GetAllUsers()
            {
                return users;
            }

            public User GetUserById(int id)
            {
                return users.FirstOrDefault(u => u.Id == id);
            }

            public void DeleteUser(int id)
            {
                var user = users.FirstOrDefault(u => u.Id == id);
                if (user != null)
                    users.Remove(user);
            }
        }
    }
}
