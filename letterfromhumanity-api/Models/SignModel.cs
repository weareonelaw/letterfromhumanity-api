using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace letterfromhumanityapi.Models
{
    public class Sign
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Country { get; set; }
        }
}
