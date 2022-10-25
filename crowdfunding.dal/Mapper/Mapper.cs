using crowdfunding.dal.Entities;
using System;
using System.Data;

namespace crowdfunding.dal.Mapper
{
    public static class Mapper
    {
        /// <summary>
        /// METHOD : CONVERT PROJECT
        /// </summary>
        /// <param name="reader"></param>
        /// <returns>Object : Project</returns>
        public static Project ConvertProject(IDataRecord reader)
        {
            if (reader == null) return null;
            return new Project() 
            { 
                Id = (int)reader[nameof(Project.Id)],
                Created = (DateTime)reader[nameof(Project.Created)],
                Modified = (DateTime)reader[nameof(Project.Modified)],
                Name = (string)reader[nameof(Project.Name)],
                Description = (string)reader[nameof(Project.Description)],
                UrlVideo = (string)reader[nameof(Project.UrlVideo)],
                UrlPicture = (string)reader[nameof(Project.UrlPicture)],
                Money_Ceiling = (double)reader[nameof(Project.Money_Ceiling)],
                UserId = (int)reader[nameof(Project.UserId)]
            };
        }
        // -------------------------------------------------------------------------     
        /// <summary>
        /// METHOD : CONVERT USER
        /// </summary>
        /// <param name="reader"></param>
        /// <returns>Object : User</returns>
        public static User ConvertUser(IDataRecord reader)
        {
            return new User()
            {
                Id = (int)reader[nameof(Project.Id)],
                Created = (DateTime)reader[nameof(User.Created)],
                Modified = (DateTime)reader[nameof(User.Modified)],
                FirstName = (string)reader[nameof(User.FirstName)],
                LastName = (string)reader[nameof(User.LastName)],
                Email = (string)reader[nameof(User.Email)],
                User_Category = (int)reader[nameof(User.User_Category)]
            };
        }
    }
}