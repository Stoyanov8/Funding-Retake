﻿
namespace Funding.Test.Services
{
    using Funding.Data.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;
    using Moq;
    using System;

    public class FakeUserManager : UserManager<User>
        {
            public FakeUserManager()
                : base(new Mock<IUserStore<User>>().Object,
                      new Mock<IOptions<IdentityOptions>>().Object,
                      new Mock<IPasswordHasher<User>>().Object,
                      new IUserValidator<User>[0],
                      new IPasswordValidator<User>[0],
                      new Mock<ILookupNormalizer>().Object,
                      new Mock<IdentityErrorDescriber>().Object,
                      new Mock<IServiceProvider>().Object,
                      new Mock<ILogger<UserManager<User>>>().Object)
            { }

        }
    }
