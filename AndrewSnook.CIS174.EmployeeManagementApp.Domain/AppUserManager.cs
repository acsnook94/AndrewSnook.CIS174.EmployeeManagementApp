﻿using AndrewSnook.CIS174.EmployeeManagementApp.Domain;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;

namespace AndrewSnook.CIS174.EmployeeManagementApp
{
    public class AppUserManager : UserManager<AppUser>
    {
         public AppUserManager(IUserStore<AppUser> store)
            : base(store)
        {
        }

    // this method is called by Owin therefore best place to configure your User Manager
    public static AppUserManager Create(
        IdentityFactoryOptions<AppUserManager> options, IOwinContext context)
        {
            var manager = new AppUserManager(
                new UserStore<AppUser>(context.Get<EmployeeContext>()));

            // optionally configure manager here
            return manager;
        }
    }
}
