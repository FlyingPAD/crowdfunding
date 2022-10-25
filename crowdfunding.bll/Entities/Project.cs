using System;
using System.Data.SqlTypes;

namespace crowdfunding.bll.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string UrlVideo { get; set; }
        public string UrlPicture { get; set; }
        public double Money_Ceiling { get; set; }
        public int UserId { get; set; }
    }
}