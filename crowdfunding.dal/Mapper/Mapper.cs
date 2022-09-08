using crowdfunding.dal.Entities;
using System;
using System.Data;

namespace crowdfunding.dal.Mapper
{
    public static class Mapper
    {
        public static Project ConvertProject(IDataRecord reader)
        {
            if (reader == null) return null;
            return new Project() 
            { 
                Id = (int)reader[nameof(Project.Id)],
                Name = (string)reader[nameof(Project.Name)],
                Created = (DateTime)reader[nameof(Project.Created)],
                Modified = (DateTime)reader[nameof(Project.Modified)]
            };
        }
    }
}