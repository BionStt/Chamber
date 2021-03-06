﻿using System;
using System.Collections.Generic;
using Chamber.Domain.DomainModel;

namespace Chamber.Domain.Interfaces.Services
{
    public partial interface IRoleService
    {
        IList<MembershipRole> AllRoles();
        void Delete(MembershipRole role);
        MembershipRole GetRole(string rolename, bool removeTracking = false);
        MembershipRole GetRole(Guid id);
        IList<MembershipUser> GetUsersForRole(string roleName);
        MembershipRole CreateRole(MembershipRole role);
    }
}