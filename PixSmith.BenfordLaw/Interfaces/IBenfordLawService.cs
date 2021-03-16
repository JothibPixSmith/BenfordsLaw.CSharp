using PixSmith.BenfordLaw.Domain;

namespace PixSmith.BenfordLaw.Interfaces
{
    public interface IBenfordLawService
    {
        FrequencyOfDistribution[] VerifyIntegerSet(long[] integerSet);
    }
}
