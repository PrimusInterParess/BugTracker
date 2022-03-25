﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTracker.Models.ViewModels.Department;

namespace BugTracker.Core.Contracts
{
    public interface IDepartmentService
    {
        Dictionary<string, string> ValidateDepartment(AddDepartmentFormModel department);

        bool Save(AddDepartmentFormModel department);
    }
}