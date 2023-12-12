using IntroToDependencyInversionPrinciple.ServiceExample.DomainModel;

namespace IntroToDependencyInversionPrinciple.ServiceExample.DomainServices
{
    internal interface IPlaceLookup
    {
        Place Lookup(Position position);
    }
}
