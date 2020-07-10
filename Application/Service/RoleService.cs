using Domain;
using Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Application.Service
{
    public interface IRoleService : IEntityService<AppRole> { }
    public class RoleService : EntityService<AppRole>, IRoleService
    {
        public RoleService(DataContext context, IUserAccessor userAccessor) : base(context, userAccessor)
        {
        }
    }
}
