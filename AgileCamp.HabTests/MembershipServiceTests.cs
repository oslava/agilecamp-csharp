using System;
using System.Linq;
using Moq;
using NUnit.Framework;

namespace AgileCamp.HabTests
{
    public class MembershipServiceTests
    {
        [Test]
        public void UserFoundTest()
        {
            Mock<IDbContext> moq = new Mock<IDbContext>(MockBehavior.Strict);
            moq.Setup(x => x.Query<User>())
                .Returns(new [] {new User
                {
                    Id = 2
                }}.AsQueryable());

            var membershipService = new MembershipService(moq.Object);

            Assert.IsNotNull(membershipService.Find(2));
            moq.Verify(x => x.Query<User>(), Times.Exactly(1));
        }

        [Test]
        public void UserNotFoundTest()
        {
            Mock<IDbContext> moq = new Mock<IDbContext>(MockBehavior.Strict);
            moq.Setup(x => x.Query<User>())
                .Returns(Enumerable.Empty<User>().AsQueryable());

            var membershipService = new MembershipService(moq.Object);

            Assert.Throws<ArgumentException>(() => membershipService.Find(2));
            moq.Verify(x => x.Query<User>(), Times.Exactly(1));
        }
    }
}