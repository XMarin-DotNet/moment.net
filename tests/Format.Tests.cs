using System;
using System.Globalization;
using NUnit.Framework;
using Shouldly;

namespace moment.net.Tests
{
    [TestFixture]
    public class FormatTests
    {
        [Test]
        public void FormatShouldReturnIsoStringWithNoSpecifiedFormatString()
        {
            var date = new DateTime(2020, 10, 04);
            var formattedDate = date.Format();

            formattedDate
                .ShouldBe("2020-10-04T00:00:00+01:00");
        }
        
        [Test]
        public void FormatShouldReturnIsoStringWithSpecifiedFormatString()
        {
            var date = new DateTime(2020, 10, 04);
            var formattedDate = date.Format("yyy MMM hh");

            formattedDate
                .ShouldBe("2020 Oct 12");
        }
        
        [Test]
        public void FormatShouldReturnIsoStringWithSpecifiedFormatStringAndCulture()
        {
            var date = new DateTime(2020, 10, 04);
            var culture = new CultureInfo("fr-FR", false);
            var formattedDate = date.Format("yyy MMM hh", culture);

            formattedDate
                .ShouldBe("2020 oct. 12");
        }
    }
}
