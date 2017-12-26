using System;
using System.Collections.Generic;
using FluentAssertions;
using PPC_Rental_2017.Models;
namespace PPCRental2017.AcceptanceTests.Support
{
    public class ReferenceUserList : Dictionary<string, USER>
    {
        public USER GetbyID(string usID)
        {
            return this[usID.Trim()].Should().NotBeNull()
                .And.Subject.Should().BeOfType<USER>().Which;
        }
    }
}
