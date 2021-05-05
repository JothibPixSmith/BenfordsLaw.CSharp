using System.IO;
using PixSmith.BenFordsLaw.CSharp.UnitTests.Models;

namespace PixSmith.BenFordsLaw.CSharp.UnitTests.Context
{
    public class BenFordLawServiceContext
    {
        public BenFordLawServiceContext()
        {
            var csvLines = File.ReadAllLines("./tallest_buildings_test_data_set.csv");

            this.TallestBuildings = new TallestBuildingDataSet[csvLines.Length - 1];

            for (var i = 1; i < csvLines.Length; i++)
            {
                var splitLine = csvLines[i].Split('|');

                this.TallestBuildings[i - 1] = new TallestBuildingDataSet
                {
                    Category = splitLine[0],
                    Structure = splitLine[1],
                    Country = splitLine[2],
                    City = splitLine[3],
                    Meters = double.Parse(splitLine[4]),
                    Feet = double.Parse(splitLine[5].Replace("\"", string.Empty)),
                    Year = int.Parse(splitLine[6].Replace("\"", string.Empty)),
                    Coordinates = splitLine[7]
                };
            }
        }

        protected TallestBuildingDataSet[] TallestBuildings { get; }
    }
}
