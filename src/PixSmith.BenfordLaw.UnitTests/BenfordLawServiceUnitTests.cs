using System.Linq;
using PixSmith.BenFordsLaw.CSharp.Services;
using PixSmith.BenFordsLaw.CSharp.Services.Interfaces;
using PixSmith.BenFordsLaw.CSharp.UnitTests.Context;
using Xunit;

namespace PixSmith.BenFordsLaw.CSharp.UnitTests
{
    public class BenFordLawServiceUnitTests : BenFordLawServiceContext
    {
        [Fact]
        public void TallestBuildingDataSetTest()
        {
            IBenFordLawService service = new BenFordLawService();

            var resultSet = service.VerifyDataSet(this.TallestBuildings.Select(x => x.Meters).ToArray());

            Assert.Equal(resultSet.Length, resultSet.Count(x => x.ExpectedPercentage > 0));
        }
    }
}
