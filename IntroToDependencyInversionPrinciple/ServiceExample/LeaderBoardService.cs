using IntroToDependencyInversionPrinciple.ServiceExample.DomainModel;
using IntroToDependencyInversionPrinciple.ServiceExample.DomainServices;

namespace IntroToDependencyInversionPrinciple.ServiceExample
{
    internal class LeaderBoardService
    {
        private ILocator _locator;
        private IPlaceLookup _placeLookup;
        private IDbService _dbService;

        public LeaderBoardService(ILocator locator, IPlaceLookup placeLookup, IDbService dbService)
        {
            _dbService = dbService;
            _placeLookup = placeLookup;
            _locator = locator;
        }

        public Leaderboard GetLeaderBoard()
        {
            // hent posisjon
            var position = _locator.Get();

            // slå opp sted ut fra position
            var place = _placeLookup.Lookup(position);

            // hent leaderboard fra db ut fra sted
            var leaderboard = _dbService.GetLeaderboard(place);

            return leaderboard;
        }
    }
}
