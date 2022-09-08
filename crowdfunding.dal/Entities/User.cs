using System;

namespace crowdfunding.dal.Entities
{
    public class User
    {
        int Id { get; set; }
        string Name { get; set; }
        DateTime Created { get; set; }
        DateTime Modified { get; set; }
    }
}