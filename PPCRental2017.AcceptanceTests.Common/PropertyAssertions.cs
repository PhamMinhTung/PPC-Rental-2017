using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPC_Rental_2017.Models;
using FluentAssertions;

namespace PPCRental2017.AcceptanceTests.Common
{
    public class PropertyAssertions
    {
        public static void FoundPropertyShouldMatchTitles(IEnumerable<PROPERTY> foundProperty, IEnumerable<string> expectedTitles)
        {
            foundProperty.Select(x => x.PropertyName).Should().Contain(expectedTitles);
        }
        public static void HomeScreenShouldShow(IEnumerable<PROPERTY> ShownName, IEnumerable<string> expected)
        {
            ShownName.Select(b => b.PropertyName).Should().Contain(expected);
        }
        public static void HomeScreenShouldShow(IEnumerable<PROPERTY> shownBooks, string expectedTitle)
        {
            shownBooks.Select(b => b.PropertyName).Should().Contain(expectedTitle);
        }
        public static void ManageShouldShowList(IEnumerable<PROPERTY> shownPROPERTYs, IEnumerable<string> expectedPROPERTYNames)
        {
            shownPROPERTYs.Select(b => b.PropertyName).Should().Contain(expectedPROPERTYNames);
        }
    }
}
