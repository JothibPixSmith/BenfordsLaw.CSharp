using PixSmith.BenFordsLaw.CSharp.Domain;

namespace PixSmith.BenFordsLaw.CSharp.Services.Interfaces
{
    public interface IBenFordLawService
    {
        FrequencyOfOccurrence[] VerifyDataSet(double[] integerSet);
    }
}
