﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Core.Contracts
{
    public interface IUserService
    {
        string GetAdminId(ClaimsPrincipal user);
        string GetUserId(ClaimsPrincipal user);
    }
}