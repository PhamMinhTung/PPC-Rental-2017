using System.Collections.Generic;
using PPC_Rental_2017.Models;
using FluentAssertions;

namespace PPC_Rental_2017.AcceptanceTests.Support
{
    public class ReferencePostList : Dictionary<string, PROPERTY>
    {
        public PROPERTY GetById(string projectId)
        {
            return this[projectId.Trim()].Should().NotBeNull()
                                        .And.Subject.Should().BeOfType<PROPERTY>().Which;
        }
    }
}
