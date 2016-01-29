using System;
using System.Linq;

namespace AgileCamp.HabTests
{
    public class MembershipService
    {
        private readonly IDbContext dbContext;

        public MembershipService(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public User Find(int id)
        {
            var user = dbContext.Query<User>()
                .SingleOrDefault(x => x.Id == id);

            if (user == null)
                throw new ArgumentException();

            return user;
        }
    }
}