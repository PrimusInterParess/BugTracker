﻿using System.Security.Claims;
using BugTracker.Models.ServiceModels;
using BugTracker.Models.ServiceModels.Organization;
using BugTracker.Models.ViewModels.Organization;

namespace BugTracker.Core.Contracts;

using Models.ViewModels.Organization;

public interface IOrganizationService
{
    bool AlreadyExists(string organizationName, string userId);

    bool Delete(string organizationId);

    string Save(string name, string countryName, string townName, string streetName, string streetNumber,
        string logoUrl, string userId);

    OrganizationServiceModel GetOrganizationByUserId(string userId);

    OrganizationServiceModel GetOrganizationById(string organizationId);

    string GetOrganizationIdByUserId(string userId);

    List<OrganizationServiceModel> GetAllOrganizationsByUser(string userId);

    bool Edit(string organizationId, string name, string country, string townName, string streetName, string streetNumber, string logoUrl);

    string GetOrganizationNameById(string id);

}

