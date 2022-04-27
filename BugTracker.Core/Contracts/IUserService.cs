﻿namespace BugTracker.Core.Contracts
{
    public interface IUserService
    {
        bool IsUserAdministrator(string user);
        bool IsUserEmployee(string user);
        bool IsAdminAuthorized(string userId,string organizationId);


    }
}
