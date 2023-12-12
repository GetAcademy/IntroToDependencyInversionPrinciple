using IntroToDependencyInversionPrinciple.ServiceExample.DomainModel;

namespace IntroToDependencyInversionPrinciple.ServiceExample.DomainServices
{
    internal interface IDbService
    {
        Leaderboard GetLeaderboard(Place place);
    }
}
