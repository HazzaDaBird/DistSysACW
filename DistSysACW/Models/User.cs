using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DistSysACW.Models
{
    public class User
    {
        #region Task2
        // TODO: Create a User Class for use with Entity Framework
        // Note that you can use the [key] attribute to set your ApiKey Guid as the primary key 
        #endregion
        [Key]
        public string ApiKey { get; set; }
        public string UserName { get; set; }
        public string property { get; set; }
        public User() { }

    }

    #region Task13?
    // TODO: You may find it useful to add code here for Logging
    #endregion

    public static class UserDatabaseAccess
    {
        #region Task3 
        // TODO: Make methods which allow us to read from/write to the database 
        #endregion
        public static void AddUsername(UserContext context)
        {
            //Create
            User usr = new User() { UserName = "New User" };
            context.Users.Add(usr);

            //Read
            User u = context.Users.FirstOrDefault(u => u.UserName == "New User");

            //update
            u.UserName = "Updated User";

            //Delete
            context.Users.Remove(usr);

            //Save to underlying database
            context.SaveChanges();
        }
        //Read
        //User u = context.Users.FirstOrDefault(u => u.UserName == "New User");

        //u.UserName = "Updated Student";

        //context.Users.Remove(u);

        //context.SaveChanges();




    }


}