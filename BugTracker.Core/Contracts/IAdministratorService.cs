﻿using BugTracker.Models.ViewModels.Administrator;

namespace BugTracker.Core.Contracts;

public interface IAdministratorService
{
    bool Register(RegisterAdminFormModel admin, string userId);
}