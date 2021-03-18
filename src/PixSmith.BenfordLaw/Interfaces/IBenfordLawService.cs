using PixSmith.BenfordsLaw.CSharp.Domain;

namespace PixSmith.BenfordsLaw.CSharp.Services.Interfaces
{
    public interface IBenfordLawService
    {
        FrequencyOfDistribution[] VerifyDataSet(double[] integerSet);
    }
}
