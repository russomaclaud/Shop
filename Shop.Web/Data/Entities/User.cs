namespace Shop.Web.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity;

    public class User : IdentityUser
    {
        public String FirstName { get; set; }

        public String LastName { get; set; }
    }
}
