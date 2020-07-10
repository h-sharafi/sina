using System.Collections.Generic;
using Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Service
{
    public interface IAccessAbleFileService: IEntityService<AccessAbleFile>
    {
        
    }
    public class AccessAbleFileService : EntityService<AccessAbleFile>, IAccessAbleFileService
    {
        public AccessAbleFileService(DataContext context, IUserAccessor userAccessor) : base(context, userAccessor)
        {
        }
    }
}