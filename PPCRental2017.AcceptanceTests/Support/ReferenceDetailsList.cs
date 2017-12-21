using System.Collections.Generic;
using PPC_Rental_2017.Models;
using FluentAssertions;

namespace PPCRental2017.AcceptanceTests.Support
{
    public class ReferenceDetailsList : Dictionary<string, PROPERTY>
    {
        public PROPERTY GetById(string projectId)
        {
            return this[projectId.Trim()].Should().NotBeNull()
                                      .And.Subject.Should().BeOfType<PROPERTY>().Which;
        }
    }
}
