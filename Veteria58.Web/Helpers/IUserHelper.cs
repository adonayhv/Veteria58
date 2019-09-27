﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Veteria58.Web.Data.Entities;
using Veteria58.Web.Models;

namespace Veteria58.Web.Helpers
{
    //es una interfase
 public   interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

        Task CheckRoleAsync(string roleName);

        Task AddUserToRoleAsync(User user, string roleName);

        Task<bool> IsUserInRoleAsync(User user, string roleName);

        Task<SignInResult> LoginAsync(LoginViewModel model);

        Task LogoutAsync();

        Task<bool> DeleteUserAsync(string email);

        Task<IdentityResult> UpdateUserAsync(User user);

        Task<SignInResult> ValidatePasswordAsync(User user, string password);


    }
}
