using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DK_NVQS.Identity
{
    public class AppUser : IdentityUser
    {
        public string CitizenID { get; set; }
        public string Name { get; set; }
        public Nullable<bool> Gender { get; set; }
        public Nullable<DateTime> DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Hometown { get; set; }
    }
}