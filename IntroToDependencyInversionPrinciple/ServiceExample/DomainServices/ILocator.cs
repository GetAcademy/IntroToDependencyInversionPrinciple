using IntroToDependencyInversionPrinciple.ServiceExample.DomainModel;

namespace IntroToDependencyInversionPrinciple.ServiceExample.DomainServices
{
    internal interface ILocator
    {
        Position Get();
    }
}
