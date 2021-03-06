﻿// Copyright(c) Microsoft Corporation. 
// All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the solution root folder for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoLocal.TimeTracker.Dashboard.ViewModels;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace GoLocal.TimeTracker.Dashboard.Interfaces
{
    public interface IWeeklyReportHoursService<T>
    {
        Task<T> GetViewModel(DateTime date, int pageIndex, int pageSize);

        Task<T> GetWeeklyReportHours(DateTime dt, int pageIndex, int pageSize = 10);

        Task WkLdReq();

        Task<MiddleTier.Models.UserProfile> GetUserProfile(ClaimsPrincipal user, HttpContext httpContext);

        Task<T> GetSearchResults(DateTime dt, string searchQuery, int pageIndex, int pageSize);
    }
}
