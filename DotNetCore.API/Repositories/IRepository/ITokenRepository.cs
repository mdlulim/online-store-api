﻿using Microsoft.AspNetCore.Identity;

namespace DotNetCore.API.Repositories.IRepository
{
    public interface ITokenRepository
    {

       string CreateJWTToken(IdentityUser user, List<string> roles);
    }
}
