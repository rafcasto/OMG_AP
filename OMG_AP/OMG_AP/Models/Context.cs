using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace OMG_AP.Models
{
   public class Context
    {
        public List<User> Users { get; set; }

        public User FindUserBy(string permission) 
        {
            if (!Users.Any()) 
            {
                throw new Exception("User has not been initialized or is empty"); 
            }

            var user = Users.FirstOrDefault(user => string.Equals(user.Permission, permission));

            if (user == null) 
            {
                throw new Exception($"Did not find any user with permission {permission}");
            }

            return user;
        }
    }
}
