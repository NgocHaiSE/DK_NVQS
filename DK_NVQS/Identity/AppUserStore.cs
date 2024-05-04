using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DK_NVQS.Identity
{
    public class AppUserStore : UserStore<AppUser>
    {
        public AppUserStore(AppDbContext dbContext) : base(dbContext) { }
    }
}